using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using BusinessApp.Repositories;
using NHibernate;

namespace BusinessApp.Services
{
   public class EnqueriesRepository : BaseRepository<Enqueries>, IEnqueriesRepository
    {
       
        public EnqueriesRepository(ISession session) : base(session)
       {
            
        }

       public List<Enqueries> GetAllEnqueriesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
