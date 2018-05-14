using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
  public  interface IOrderLineService
    {
        OrderLine GetOrderLineByOrderId(long orderId);
        void Delete(long id);
        void SaveOrUpdate(OrderLine orderLineModel);
        long Save(OrderLine orderLineModel);
        IList<OrderLine> GetAllRecords();
        OrderLine Get(long id);
    }
}
