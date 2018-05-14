using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
  public  interface IBillService
    {
        List<Bill> GetBillsByClientId(long clientId);
        void Delete(Bill bill);
        void SaveOrUpdate(Bill bill);
        long Save(Bill bill);
        IList<Bill> GetAllRecords();
        Bill Get(long id);
    }
}
