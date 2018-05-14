using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Enqueries : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public string Notes { get; set; }
        //  private Images Pictures { get; set; }
        public DateTime EnquiryDate { get; set; }
    }
}
