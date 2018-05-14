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
   public class AccountService:IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

        }
        public List<Account> GetAccountsByUserId(long userId)
       {
            return _accountRepository.GetAllRecords("SELECT * FROM [Account] WHERE ClientId = " + userId.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _accountRepository.Delete(id);
       }

       public void SaveOrUpdate(Account account)
       {
            _accountRepository.SaveOrUpdate(account);
       }

       public long Save(Account account)
       {
           return _accountRepository.Save(account);
       }

       public IList<Account> GetAllRecords()
       {
            return _accountRepository.GetAllRecords("SELECT * FROM [Account]");
        }

       public Account Get(long id)
       {
           return _accountRepository.Get(id);
       }
    }
}
