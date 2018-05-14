using BusinessApp.Contracts.Repositories;
using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusinessAppApi.Controllers
{
    public class AccountModelController : ApiController
    {
        private readonly IAccountRepository _accountRepository;

        public AccountModelController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        // GET api/ptemployees
        [Route("api/accounts/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var accounts = _accountRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, accounts);
            return response;
        }
        [Route("api/accounts/allbyuserid/{id}")]
        public HttpResponseMessage GetByUserId(long id)
        {
            var accounts = _accountRepository.GetAccountsByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, accounts);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/accounts/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var accounts = _accountRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, accounts);
            return response;
        }
  

        [Route("api/accounts")]
        public HttpResponseMessage Post(Account account)
        {
            var accounts = _accountRepository.Save(account);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, accounts);
            return response;
        }

        [Route("api/accounts/update/{id}")]
        public HttpResponseMessage Put(Account account)
        {
             _accountRepository.SaveOrUpdate(account);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/accounts/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _accountRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

    }
}
