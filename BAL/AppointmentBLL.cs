using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BAL
{
    public class AppointmentBLL
    {
        AppointmentDAL aDAL = new AppointmentDAL();
        public List<Appointment> ListAppointment(DateTime d)
        {
            return aDAL.ListAppointment(d);
        }
        public Appointment getByID(int ID)
        {
            return aDAL.getAppointmentById(ID);
        }
    }
}
