using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Quotes : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public string Body { get; set; }
        //   private IList<Products> ProductList { get; set; }
        public DateTime DateSent { get; set; }
        public long UserId { get; set; }
    }
    
}
