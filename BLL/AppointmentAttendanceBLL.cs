﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppointmentAttendanceBLL
    {
        AppoinmentAttendanceDAL aaDal = new AppoinmentAttendanceDAL();
        public List<AppoimentAttendance> checkInvited(Person p)
        {
            List<AppoimentAttendance> list = aaDal.checkInvited(p);
            if (list.Count > 0) return list;
            else return null;
        }
        public void AcceptInvite(int aID, Person p)
        {
            aaDal.AcceptInvite(aID, p);
        }
        public void RejectInvite(int aID, Person p)
        {
            aaDal.RejectInvite(aID, p);
        }
        public List<AppoimentAttendance> getListByID(int ID)
        {
            return aaDal.getByAppointmentID(ID);
        }
        public Boolean RemoveAtt(int ID)
        {
            if(ID <= 0)
            {
                return false;
            }
            aaDal.RemoveAtt(ID);
            return true;
        }
        public Boolean AddAtt(Person p, int AppID) { 
            if(p == null || AppID <= 0) { return false; }
            aaDal.AddAtt(p, AppID);
            return true;
        }
        public void SetHost(int aID, Person p)
        {
            aaDal.SetHost(aID, p);
        }
    }
}
