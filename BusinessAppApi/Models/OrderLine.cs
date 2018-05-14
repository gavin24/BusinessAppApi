using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class OrderLine : Model
    {

        public long Id { get; set; }
        public long OrderNumber { get; set; }
        public long ClientNumber { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
    }
}
