using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IBillRepository : IRepository<Bill>
    {
       List<Bill> GetBillsByClientId(long clientId);
   }
}
