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
   public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        
        public CartRepository(ISession session) : base(session)
       {
            
        }

       public Cart GetCartByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
