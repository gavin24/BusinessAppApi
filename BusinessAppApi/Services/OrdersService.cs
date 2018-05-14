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
   public class OrdersService:IOrderService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;

        }

       public List<Orders> GetOrdesByClientId(long clientId)
       {
            return _ordersRepository.GetAllRecords("SELECT * FROM [Orders] WHERE ClientId = " + clientId.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _ordersRepository.Delete(id);
       }

       public void SaveOrUpdate(Orders orders)
       {
            _ordersRepository.SaveOrUpdate(orders);
       }

       public long Save(Orders orders)
       {
            return _ordersRepository.Save(orders);
        }

       public IList<Orders> GetAllRecords()
       {
            return _ordersRepository.GetAllRecords("SELECT * FROM [Orders]");
        }

       public Orders Get(long id)
       {
            return _ordersRepository.Get(id);
        }
    }
}
