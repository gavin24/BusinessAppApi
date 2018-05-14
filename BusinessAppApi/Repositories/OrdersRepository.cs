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
   public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        
        public OrdersRepository(ISession session) : base(session)
       {
            
        }

       public List<Orders> GetOrdesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
