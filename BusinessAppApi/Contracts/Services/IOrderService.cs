using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
  public  interface IOrderService
    {
        List<Orders> GetOrdesByClientId(long clientId);
        void Delete(long id);
        void SaveOrUpdate(Orders orders);
        long Save(Orders orders);
        IList<Orders> GetAllRecords();
        Orders Get(long id);
    }
}
