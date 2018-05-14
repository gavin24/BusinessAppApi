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
    public class EnqueriesController : ApiController
    {
        private readonly IEnqueriesRepository _enqueriesRepository;

        public EnqueriesController(IEnqueriesRepository enqueriesRepository)
        {
            _enqueriesRepository = enqueriesRepository;
        }

        // GET api/ptemployees
        [Route("api/enqueries/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var enqueriesList = _enqueriesRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, enqueriesList);
            return response;
        }
        [Route("api/enqueries/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var enqueriesList = _enqueriesRepository.GetAllEnqueriesByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, enqueriesList);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/enqueries/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var enqueriesList = _enqueriesRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, enqueriesList);
            return response;
        }


        [Route("api/enqueries")]
        public HttpResponseMessage Post(Enqueries enqueries)
        {
            var enqueriesList = _enqueriesRepository.Save(enqueries);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, enqueriesList);
            return response;
        }

        [Route("api/enqueries/update/{id}")]
        public HttpResponseMessage Put(Enqueries enqueries)
        {
            _enqueriesRepository.SaveOrUpdate(enqueries);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/enqueries/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _enqueriesRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
    
}
