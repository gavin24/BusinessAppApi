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
   public class LocationService:ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;

        }

       public Location GetLocationByCustomerId(long customerId)
       {
            return _locationRepository.GetAllRecords("SELECT * FROM [Location] WHERE UserId = " + customerId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _locationRepository.Delete(id);
       }

       public void SaveOrUpdate(Location location)
       {
            _locationRepository.SaveOrUpdate(location);
       }

       public long Save(Location location)
       {
           return _locationRepository.Save(location);
       }

       public IList<Location> GetAllRecords()
       {
            return _locationRepository.GetAllRecords("SELECT * FROM [Location]");
        }

       public Location Get(long id)
       {
           return _locationRepository.Get(id);
       }
    }
}
