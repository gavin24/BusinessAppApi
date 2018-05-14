using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IQuotesService
    {
        List<Quotes> GetQuotesByClientId(long clientId);
        List<Quotes> GetQuotesByUserId(long userId);
        void Delete(long id);
        void SaveOrUpdate(Quotes quotes);
        long Save(Quotes quotes);
        IList<Quotes> GetAllRecords();
        Quotes Get(long id);
    }
}
