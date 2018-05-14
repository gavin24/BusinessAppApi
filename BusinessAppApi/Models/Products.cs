using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Products : Model
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public double PriceAmount { get; set; }
        public long CatergoryId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public long ProductImageId { get; set; }
    }
}
