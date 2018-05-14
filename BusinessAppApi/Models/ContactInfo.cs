using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class ContactInfo : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string SecondaryEmail { get; set; }
    }
}

