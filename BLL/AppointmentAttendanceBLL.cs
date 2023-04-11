using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppointmentAttendanceBLL
    {
        AppoinmentAttendanceDAL aaDal = new AppoinmentAttendanceDAL();
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
    }
}
