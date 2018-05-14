using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Images : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        public byte[] ImageBytes { get; set; }
        public string ImageName { get; set; }
        public string ImageExtension { get; set; }
    }
}

