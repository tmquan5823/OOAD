using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AppointmentDAL : Database
    {
        public List<Appointment> ListAppointment(DateTime d, Person p)
        {
            List<Appointment> appointments = new List<Appointment>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.CommandText = "ListAppointment";
            sqlcmd.Parameters.Add("@AttID", System.Data.SqlDbType.Int).Value = p.Person_ID;
            sqlcmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = d.ToString("yyyy-MM-dd");
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Appointment app = new Appointment();
                app.Appointment_ID = reader.GetInt32(0);
                app.Title = reader.GetString(1);
                app.HostID = reader.GetInt32(2);
                app.StartTime = reader.GetTimeSpan(3);
                app.EndTime = reader.GetTimeSpan(4);
                app.AppointmentLocation = reader.GetString(5);
                app.AppointmentDescription = reader.GetString(6);
                app.AppointmentDate = reader.GetDateTime(7);
                appointments.Add(app);
            }
            reader.Close();
            return appointments;
        }
        public Appointment getAppointmentById(int ID)
        {
            Appointment app = new Appointment();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Appointment where Appointment_ID = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.Appointment_ID = reader.GetInt32(0);
                app.Title = reader.GetString(1);
                app.HostID = reader.GetInt32(2);
                app.StartTime = reader.GetTimeSpan(3);
                app.EndTime = reader.GetTimeSpan(4);
                app.AppointmentLocation = reader.GetString(5);
                app.AppointmentDescription = reader.GetString(6);
                app.AppointmentDate = reader.GetDateTime(7);
            }
            reader.Close();
            return app;
        }
        public Boolean checkAppointment(Appointment A, Person p)
        {
            Boolean result = false;

            List<Appointment> listA = this.ListAppointment(A.AppointmentDate, p);
            foreach (var item in listA)
            {
                if (TimeSpan.Compare(A.StartTime, item.StartTime) > 0 && TimeSpan.Compare(A.StartTime, item.EndTime) < 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public void InsertAppointment(Appointment A)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            DateTime start = A.AppointmentDate + A.StartTime;
            DateTime end = A.AppointmentDate + A.EndTime;
            sqlcmd.CommandText = "insert into Appointment (Title, HostID, AppointmentDate, StartTime, EndTime, AppointmentLocation, AppointmentDescription ) values('" + A.Title + "', " + A.HostID + ", '" + A.AppointmentDate.ToString("yyyy-MM-dd") + "', '" + start.ToString("hh:mm:ss") + "', '" + end.ToString("hh:mm:ss") + "', '" + A.AppointmentLocation + "', '" + A.AppointmentDescription + "')";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public Appointment getByTitle(string s)
        {
            Appointment app = new Appointment();
            OpenConnection ();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Appointment where Title = '" + s + "'";
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                app.Appointment_ID = reader.GetInt32(0);
                app.Title = reader.GetString(1);
                app.HostID = reader.GetInt32(2);
                app.StartTime = reader.GetTimeSpan(3);
                app.EndTime = reader.GetTimeSpan(4);
                app.AppointmentLocation = reader.GetString(5);
                app.AppointmentDescription = reader.GetString(6);   
                app.AppointmentDate = reader.GetDateTime(7);
            }
            reader.Close();
            return app; 
        }
        public void RemoveAppointment(int ID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM Appointment WHERE Appointment_ID = " + ID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            return;
        }
        public void UpdateAppointment(Appointment A)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            DateTime start = A.AppointmentDate + A.StartTime;
            DateTime end = A.AppointmentDate + A.EndTime;
            sqlcmd.CommandText = "update Appointment set Title = '" + A.Title + "', HostID = " + A.HostID + ", AppointmentDate = '" + A.AppointmentDate.ToString("yyyy-MM-dd") + "', StartTime = '" + start.ToString("yyyy-MM-dd hh:mm") + "', EndTime = '" + end.ToString("yyyy-MM-dd hh:mm") + "', AppointmentLocation = '" + A.AppointmentLocation + "', AppointmentDescription = '" + A.AppointmentDescription + "' Where Appointment_ID = " + A.Appointment_ID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            return;
        }
        public int CountNumberOfAppointment()
        {
            int count = 0;
            Appointment app = new Appointment();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select count(*) from Appointment";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();

            count = reader.GetInt32(0);

            return count;
        }
    }

}
