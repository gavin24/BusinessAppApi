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
    public class ProductsController : ApiController
    {
        private readonly IProductRepository _productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        // GET api/ptemployees
        [Route("api/products/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var products = _productsRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }
        [Route("api/products/allbycatid/{id}")]
        public HttpResponseMessage GetByCatergoryId(long id)
        {
            var products = _productsRepository.GetProductsByCategoryId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/products/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var products = _productsRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }


        [Route("api/products")]
        public HttpResponseMessage Post(Products product)
        {
            var products = _productsRepository.Save(product);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }

        [Route("api/products/update/{id}")]
        public HttpResponseMessage Put(Products product)
        {
            _productsRepository.SaveOrUpdate(product);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/products/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _productsRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
    
}
