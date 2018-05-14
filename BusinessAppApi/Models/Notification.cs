using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAppApi.Enums;

namespace BusinessApp.Models
{
    public class Notification : Model
    {

        public long Id { get; set; }
        public NotficationType NotType { get; set; }
        public long UserId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public DateTime TimeSent { get; set; }
        
    }
}
