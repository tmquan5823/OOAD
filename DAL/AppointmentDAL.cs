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
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Appointment where AppointmentDate = '" + d.ToString("yyyy-MM-dd")+ "'";
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
    }
}
