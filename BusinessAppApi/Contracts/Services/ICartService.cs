using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface ICartService
    {
        Cart GetCartByClientId(long clientId);
        void Delete(long id);
        void SaveOrUpdate(Cart cart);
        long Save(Cart cart);
        IList<Cart> GetAllRecords();
        Cart Get(long id);
    }
}
