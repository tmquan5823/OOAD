using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Reminder
    {
        public int ReminderID { get; set; }
        public string ReminderTime { get; set; }
        public int AppointmentID { get; set; }
        public int ID_Attendance { get; set; }
    }
}
