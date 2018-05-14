using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IOrderLineRepository : IRepository<OrderLine>
    {
       OrderLine GetOrderLineByOrderId(long orderId);
   }
}
