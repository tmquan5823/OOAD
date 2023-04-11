using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PersonDAL : Database
    {
        public Boolean CheckUserInfo(Person p)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select UserName, UserPassword from Person where UserName = '" + p.UserName + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == p.UserPassword)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false; 
        }

        

        public List<Person> getList()
        {
            List<Person> list = new List<Person>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Person";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Person app = new Person();
                app.Person_ID = reader.GetInt32(0);
                app.Person_Name = reader.GetString(1);
                app.Tel = reader.GetString(2);
                app.Email = reader.GetString(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.UserPassword = reader.GetString(6);
                list.Add(app);
            }
            reader.Close();
            return list;
        }
        public List<Person> ListAttendance(int id)
        {
            List<Person> list = new List<Person>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.CommandText = "ListAttendance";
            sqlcmd.Parameters.Add("@aID", System.Data.SqlDbType.Int).Value = id;
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Person p = new Person();
                p.Person_ID = reader.GetInt32(0);
                p.Person_Name = reader.GetString(1);
                p.Tel = reader.GetString(2);
                p.Email = reader.GetString(3);
                p.Sex = reader.GetString(4);
                p.UserName = reader.GetString(5);
                p.UserPassword = reader.GetString(6);
                list.Add(p);
            }
            reader.Close();
            return list;
        }
        public Person getById(int ID)
        {
            Person app = new Person();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Person where Person_ID = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.Person_ID = reader.GetInt32(0);
                app.Person_Name = reader.GetString(1);
                app.Tel = reader.GetString(2);
                app.Email = reader.GetString(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.UserPassword = reader.GetString(6);
            }
            reader.Close();
            return app;
        }
        public Person getByUserName(string userName)
        {
            Person app = new Person();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Person where UserName = '" + userName + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.Person_ID = reader.GetInt32(0);
                app.Person_Name = reader.GetString(1);
                app.Tel = reader.GetString(2);
                app.Email = reader.GetString(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.UserPassword = reader.GetString(6);
            }
            reader.Close();
            return app;
        }
    }
}
