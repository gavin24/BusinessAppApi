using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Price : Model
    {

        public long Id { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }

    }
}
