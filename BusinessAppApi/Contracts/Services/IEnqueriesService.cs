using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
  public  interface IEnqueriesService
    {
        List<Enqueries> GetAllEnqueriesByClientId(long clientId);
        void Delete(long id);
        void SaveOrUpdate(Enqueries enqueries);
        long Save(Enqueries enqueries);
        IList<Enqueries> GetAllRecords();
        Enqueries Get(long id);
    }
}
