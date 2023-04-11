using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppointmentBLL
    {
        AppointmentDAL aDAL = new AppointmentDAL();
        public List<Appointment> ListAppointment(DateTime d, Person p)
        {
            return aDAL.ListAppointment(d, p);
        }
        public Appointment getByID(int ID)
        {
            return aDAL.getAppointmentById(ID);
        }
    }
}
