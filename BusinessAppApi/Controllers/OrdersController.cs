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
    public class OrdersController : ApiController
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        // GET api/ptemployees
        [Route("api/orders/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var orders = _ordersRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orders);
            return response;
        }
        [Route("api/orders/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var orders = _ordersRepository.GetOrdesByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orders);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/orders/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var orders = _ordersRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orders);
            return response;
        }


        [Route("api/orders")]
        public HttpResponseMessage Post(Orders order)
        {
            var orders = _ordersRepository.Save(order);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orders);
            return response;
        }

        [Route("api/orders/update/{id}")]
        public HttpResponseMessage Put(Orders order)
        {
            _ordersRepository.SaveOrUpdate(order);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/orders/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _ordersRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
  
}
