using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessAppApi.Enums;

namespace BusinessApp.Models
{
    public class Orders : Model
    {

        public long Id { get; set; }
        public long ClientId { get; set; }
        //  private IList<OrderLine> OrderLineItems { get; set; }
        public long OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStat { get; set; }
    }
}
