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
        public Boolean checkAppointment(Appointment appointment, Person p)
        {
            return aDAL.checkAppointment(appointment, p);
        }
        public Boolean InsertAppointment(Appointment A)
        {
            if(A.Title == "" || A.AppointmentLocation == "" || A.AppointmentDate < DateTime.Now || A.StartTime > A.EndTime) {
                return false;
            }
            aDAL.InsertAppointment(A);
            return true;
        }
        public int countAppointment()
        {
            return aDAL.CountNumberOfAppointment();
        }
        public void RemoveAppointment(int ID)
        {
            aDAL.RemoveAppointment(ID);
        }
        public void UpdateAppointment(Appointment a)
        {
            aDAL.UpdateAppointment(a);
        }
        public Appointment getByTitle(string s)
        {
            return aDAL.getByTitle(s);
        }
    }
}
