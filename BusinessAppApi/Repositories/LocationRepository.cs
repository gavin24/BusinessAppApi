using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
       
        public LocationRepository(ISession session) : base(session)
       {
          
        }

       public Location GetLocationByCustomerId(long customerId)
       {
           throw new NotImplementedException();
       }
    }
}
