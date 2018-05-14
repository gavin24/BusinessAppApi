using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Cart : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        //    private List<Products> productList { get; set; } 
        public DateTime CartCreated { get; set; }
        public int ItemAmount { get; set; }
        public double Total { get; set; }
    }
}
