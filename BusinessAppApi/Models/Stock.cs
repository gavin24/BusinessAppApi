using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Stock : Model
    {

        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime DateAccepted { get; set; }
        public string Supplier { get; set; }
    }
}
