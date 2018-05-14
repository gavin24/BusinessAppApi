using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Bill : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public long OrderId { get; set; }
        public DateTime BillSent { get; set; }
        public double Total { get; set; }
    }
}
