using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IAccountService
    {
       List<Account> GetAccountsByUserId(long userId);
       void Delete(long id);
       void SaveOrUpdate(Account account);
       long Save(Account account);
       IList<Account> GetAllRecords();
       Account Get(long id);
    }
}
