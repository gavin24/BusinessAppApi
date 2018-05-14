using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;

namespace BusinessApp.Services
{
   public class CartService:ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;

        }

       public Cart GetCartByClientId(long clientId)
       {
            return _cartRepository.GetAllRecords("SELECT * FROM [Cart] WHERE ClientId = " + clientId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _cartRepository.Delete(id);
       }

       public void SaveOrUpdate(Cart cart)
       {
            _cartRepository.SaveOrUpdate(cart);
       }

       public long Save(Cart cart)
       {
           return _cartRepository.Save(cart);
       }

       public IList<Cart> GetAllRecords()
       {
            return _cartRepository.GetAllRecords("SELECT * FROM [Cart]");
        }

       public Cart Get(long id)
       {
           return _cartRepository.Get(id);
       }
    }
}
