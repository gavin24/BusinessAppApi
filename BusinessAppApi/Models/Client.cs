using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Client : Model
    {

        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long ClientAddressId { get; set; }
     //   private IList<Address> ClientAddress { get; set; }
    }
}