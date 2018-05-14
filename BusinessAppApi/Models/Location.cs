using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Location : Model
    {

        public long Id { get; set; }
        public string CoOrdinates { get; set; }
        public long ClientId { get; set; }
        public string LocationName { get; set; }
    }
}