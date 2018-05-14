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
   public class OrderLineModelService:IOrderLineService
    {

        private readonly IOrderLineRepository _orderLineRepository;
        public OrderLineModelService(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;

        }
        public OrderLine GetOrderLineByOrderId(long orderId)
       {
            return _orderLineRepository.GetAllRecords("SELECT * FROM [OrderLine] WHERE OrderNumber = " + orderId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _orderLineRepository.Delete(id);
       }

       public void SaveOrUpdate(OrderLine orderLineModel)
       {
            _orderLineRepository.SaveOrUpdate(orderLineModel);
       }

       public long Save(OrderLine orderLineModel)
       {
           return _orderLineRepository.Save(orderLineModel);
       }

       public IList<OrderLine> GetAllRecords()
       {
            return _orderLineRepository.GetAllRecords("SELECT * FROM [OrderLine]");
        }

       public OrderLine Get(long id)
       {
          return _orderLineRepository.Get(id);
       }
    }
}
