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
    public class QuotesController : ApiController
    {
        private readonly IQuotesRepository _quotesRepository;

        public QuotesController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }

        // GET api/ptemployees
        [Route("api/quotes/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var quotes = _quotesRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, quotes);
            return response;
        }
        [Route("api/quotes/allbyuserid/{id}")]
        public HttpResponseMessage GetQuotesByUserId(long id)
        {
            var quotes = _quotesRepository.GetQuotesByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, quotes);
            return response;
        }
        [Route("api/quotes/allbyclientid/{id}")]
        public HttpResponseMessage GetQuotesByClientId(long id)
        {
            var quotes = _quotesRepository.GetQuotesByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, quotes);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/quotes/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var quotes = _quotesRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, quotes);
            return response;
        }


        [Route("api/quotes")]
        public HttpResponseMessage Post(Quotes quote)
        {
            var quotes = _quotesRepository.Save(quote);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, quotes);
            return response;
        }

        [Route("api/quotes/update/{id}")]
        public HttpResponseMessage Put(Quotes quote)
        {
            _quotesRepository.SaveOrUpdate(quote);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/quotes/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _quotesRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
