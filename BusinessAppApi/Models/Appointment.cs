using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessApp.Models
{
    public class Appointment : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long AppointmentUserId { get; set; }
        public string Notes { get; set; }
    }
}
