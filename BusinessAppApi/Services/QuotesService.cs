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
   public class QuotesService:IQuotesService
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuotesService(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;

        }

       public List<Quotes> GetQuotesByClientId(long clientId)
       {
            return _quotesRepository.GetAllRecords("SELECT * FROM [Quotes] WHERE ClientId = " + clientId.ToString()).ToList();
        }

       public List<Quotes> GetQuotesByUserId(long userId)
       {
            return _quotesRepository.GetAllRecords("SELECT * FROM [Quotes] WHERE UserId = " + userId.ToString()).ToList();
        }

       public void Delete(long id)
       {
           _quotesRepository.Delete(id);
       }

       public void SaveOrUpdate(Quotes quotes)
       {
            _quotesRepository.SaveOrUpdate(quotes);
       }

       public long Save(Quotes quotes)
       {
           return _quotesRepository.Save(quotes);
       }

       public IList<Quotes> GetAllRecords()
       {
            return _quotesRepository.GetAllRecords("SELECT * FROM [Quotes]");
        }

       public Quotes Get(long id)
       {
          return _quotesRepository.Get(id);
       }
    }
}
