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
    public class OrderLineController : ApiController
    {
        private readonly IOrderLineRepository _orderLineRepository;

        public OrderLineController(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;
        }

        // GET api/ptemployees
        [Route("api/orderline/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var orderLines = _orderLineRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orderLines);
            return response;
        }
        [Route("api/orderline/allbyuserid/{id}")]
        public HttpResponseMessage GetByOrderId(long id)
        {
            var orderLines = _orderLineRepository.GetOrderLineByOrderId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orderLines);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/orderline/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var orderLines = _orderLineRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orderLines);
            return response;
        }


        [Route("api/orderline")]
        public HttpResponseMessage Post(OrderLine orderLine)
        {
            var orderLines = _orderLineRepository.Save(orderLine);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, orderLines);
            return response;
        }

        [Route("api/orderline/update/{id}")]
        public HttpResponseMessage Put(OrderLine orderLine)
        {
            _orderLineRepository.SaveOrUpdate(orderLine);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/orderline/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _orderLineRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
