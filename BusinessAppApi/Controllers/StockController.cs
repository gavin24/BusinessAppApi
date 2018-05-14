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
    public class StockController : ApiController
    {
        private readonly IStockRepository _stockRepository;

        public StockController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        // GET api/ptemployees
        [Route("api/stock/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var stocks = _stockRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, stocks);
            return response;
        }
        [Route("api/stock/allbyproductid/{id}")]
        public HttpResponseMessage GetByProductId(long id)
        {
            var stocks = _stockRepository.GetStockByProductId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, stocks);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/stock/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var stocks = _stockRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, stocks);
            return response;
        }


        [Route("api/stock")]
        public HttpResponseMessage Post(Stock stock)
        {
            var stocks = _stockRepository.Save(stock);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, stocks);
            return response;
        }

        [Route("api/stock/update/{id}")]
        public HttpResponseMessage Put(Stock stock)
        {
            _stockRepository.SaveOrUpdate(stock);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/stock/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _stockRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
