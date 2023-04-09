﻿using System;
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

    }
}
