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
   public class BillService:IBillService
    {
        private readonly IBillRepository _billRepository;
        public BillService(IBillRepository billRepository)
        {
            _billRepository = billRepository;

        }

       public List<Bill> GetBillsByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public void Delete(Bill bill)
       {
           throw new NotImplementedException();
       }

       public void SaveOrUpdate(Bill bill)
       {
           throw new NotImplementedException();
       }

       public long Save(Bill bill)
       {
           throw new NotImplementedException();
       }

       public IList<Bill> GetAllRecords()
       {
           throw new NotImplementedException();
       }

       public Bill Get(long id)
       {
           throw new NotImplementedException();
       }
    }
}
