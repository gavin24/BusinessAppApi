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
   public class EnqueriesService:IEnqueriesService
    {
        private readonly IEnqueriesRepository _enquerieRepository;
        public EnqueriesService(IEnqueriesRepository enquerieRepository)
        {
            _enquerieRepository = enquerieRepository;

        }

       public List<Enqueries> GetAllEnqueriesByClientId(long clientId)
       {
            return _enquerieRepository.GetAllRecords("SELECT * FROM [Enqueries] WHERE ClientId = " + clientId.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _enquerieRepository.Delete(id);
       }

       public void SaveOrUpdate(Enqueries enqueries)
       {
           _enquerieRepository.SaveOrUpdate(enqueries);
       }

       public long Save(Enqueries enqueries)
       {
           return _enquerieRepository.Save(enqueries);
       }

       public IList<Enqueries> GetAllRecords()
       {
            return _enquerieRepository.GetAllRecords("SELECT * FROM [Enqueries]");
        }

       public Enqueries Get(long id)
       {
           return _enquerieRepository.Get(id);
       }
    }
}
