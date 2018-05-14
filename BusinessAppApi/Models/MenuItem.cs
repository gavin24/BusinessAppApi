using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
   public class MenuItem : Model
    {

        public long Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
    }
}
