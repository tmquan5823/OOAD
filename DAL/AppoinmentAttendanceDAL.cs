using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class AppoinmentAttendanceDAL : Database
    {
        public List<AppoimentAttendance> checkInvited(Person p)
        {
            List<AppoimentAttendance> list = new List<AppoimentAttendance>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.CommandText = "checkInvited";
            sqlcmd.Parameters.Add("@aID", System.Data.SqlDbType.Int).Value = p.Person_ID;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                AppoimentAttendance tmp = new AppoimentAttendance();
                tmp.Appointment_ID = reader.GetInt32(0);
                list.Add(tmp);
            }
            reader.Close();
            return list;
        }
        public void AcceptInvite(int aID, Person p)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "update AppointmentAttendance set AttendanceStatus = 'Tham gia' where Attendance_ID = " + p.Person_ID + " and Appointment_ID = " + aID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void RejectInvite(int aID, Person p)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "update AppointmentAttendance set AttendanceStatus = 'Khong tham gia' where Attendance_ID = " + p.Person_ID + " and Appointment_ID = " + aID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public List<AppoimentAttendance> getByAppointmentID(int ID)
        {   
            List<AppoimentAttendance> list = new List<AppoimentAttendance>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from AppointmentAttendance where Appointment_ID = " + ID;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                AppoimentAttendance temp = new AppoimentAttendance();
                temp.Appointment_ID = reader.GetInt32(0);
                temp.Attendance_ID = reader.GetInt32(1);
                temp.AttendanceStatus = reader.GetString(2);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }
        public void AddAtt(Person p, int AppID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into AppointmentAttendance values(" + AppID + ", " + p.Person_ID +", 'Chua phan hoi')";
            sqlcmd.Connection = sqlCon;

            sqlcmd.ExecuteNonQuery();
        }
        public void RemoveAtt(int ID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();   
            sqlcmd.CommandType =System.Data.CommandType.Text;
            sqlcmd.CommandText = "delete from AppointmentAttendance where Attendance_ID = " + ID;
            sqlcmd.Connection = sqlCon;

            sqlcmd.ExecuteNonQuery();
        }
        public void SetHost(int aID, Person p)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into AppointmentAttendance values(" + aID + ", " + p.Person_ID +", 'Host')";
            sqlcmd.Connection = sqlCon;

            sqlcmd.ExecuteNonQuery();
        }
    }
}
