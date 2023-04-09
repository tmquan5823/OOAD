using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Appointment
    {
        public int Appointment_ID { get; set; }
        public string Title { get; set; }
        public int HostID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }   
        public string AppointmentLocation { get; set; }
        public string AppointmentDescription { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
