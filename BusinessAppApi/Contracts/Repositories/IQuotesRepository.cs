using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IQuotesRepository : IRepository<Quotes>
    {
       List<Quotes> GetQuotesByClientId(long clientId);
        List<Quotes> GetQuotesByUserId(long userId);
    }
}
