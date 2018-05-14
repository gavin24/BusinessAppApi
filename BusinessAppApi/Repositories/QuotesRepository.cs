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
   public class QuotesRepository : BaseRepository<Quotes>, IQuotesRepository
    {
        
        public QuotesRepository(ISession session) : base(session)
       {
            
        }

       public List<Quotes> GetQuotesByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public List<Quotes> GetQuotesByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
