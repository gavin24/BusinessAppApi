using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
  public  interface ILocationService
    {
        Location GetLocationByCustomerId(long customerId);
        void Delete(long id);
        void SaveOrUpdate(Location location);
        long Save(Location location);
        IList<Location> GetAllRecords();
        Location Get(long id);
    }
}
