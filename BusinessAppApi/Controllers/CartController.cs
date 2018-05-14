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
    public class CartController : ApiController
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        // GET api/ptemployees
        [Route("api/carts/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var carts = _cartRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, carts);
            return response;
        }
        [Route("api/carts/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var carts = _cartRepository.GetCartByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, carts);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/carts/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var carts = _cartRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, carts);
            return response;
        }


        [Route("api/carts")]
        public HttpResponseMessage Post(Cart cart)
        {
            var carts = _cartRepository.Save(cart);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, carts);
            return response;
        }

        [Route("api/carts/update/{id}")]
        public HttpResponseMessage Put(Cart cart)
        {
            _cartRepository.SaveOrUpdate(cart);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/carts/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _cartRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
  
}
