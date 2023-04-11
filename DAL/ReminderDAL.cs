using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ReminderDAL : Database
    {
        public List<Reminder> ListReminder(Person p)
        {
            List<Reminder> list = new List<Reminder>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Reminder where ID_Attendace = " + p.Person_ID;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Reminder reminder = new Reminder();
                reminder.ReminderID = reader.GetInt32(0);
                reminder.ReminderTime = reader.GetString(1);
                reminder.AppointmentID = reader.GetInt32(2);
                reminder.ID_Attendance = reader.GetInt32(3);
                list.Add(reminder);
            }
            reader.Close();
            return list;
        }
        public void RemoveReminder(int id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "delete Reminder WHERE ReminderID = " + id;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void AddReminder(Person p, int aID, string rTime)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into Reminder(ReminderTime, AppointmentID, ID_Attendace) values('" + rTime +"'," + aID + ", " + p.Person_ID + ")";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
    }
}
