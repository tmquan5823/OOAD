using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AppoinmentAttendanceBLL
    {
        AppoinmentAttendanceDAL aaDal = new AppoinmentAttendanceDAL();
        public List<AppoimentAttendance> getListByID(int ID)
        {
            return aaDal.getByAppointmentID(ID);
        }
    }
}
