using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ReminderBLL
    {
        ReminderDAL rDAL = new ReminderDAL();
        public List<Reminder> ListReminder(Person p)
        {
            return rDAL.ListReminder(p);
        }
        public void RemoveReminder(int id)
        {
            rDAL.RemoveReminder(id);
        }
        public void AddReminder(Person p, int aID, string rTime)
        {
            rDAL.AddReminder(p, aID, rTime);
        }
    }
}
