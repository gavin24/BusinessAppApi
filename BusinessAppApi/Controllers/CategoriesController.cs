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
    public class CategoriesController : ApiController
    {
        private readonly ICategoriesRepository _cartRepository;

        public CategoriesController(ICategoriesRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        // GET api/ptemployees
        [Route("api/categories/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var categories = _cartRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }
   
        // GET api/ptemployees/5
        [Route("api/categories/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var categories = _cartRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }


        [Route("api/categories")]
        public HttpResponseMessage Post(Categories category)
        {
            var categories = _cartRepository.Save(category);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }

        [Route("api/categories/update/{id}")]
        public HttpResponseMessage Put(Categories category)
        {
            _cartRepository.SaveOrUpdate(category);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/categories/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _cartRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
    
}
