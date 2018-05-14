using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class OrderLineRepository : BaseRepository<OrderLine>, IOrderLineRepository
    {
        
        public OrderLineRepository(ISession session) : base(session)
       {
            
        }

       public OrderLine GetOrderLineByOrderId(long orderId)
       {
           throw new NotImplementedException();
       }
    }
}
