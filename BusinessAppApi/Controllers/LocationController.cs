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
    public class LocationController : ApiController
    {
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }


        // GET api/ptemployees
        [Route("api/locations/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var locations = _locationRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, locations);
            return response;
        }
        [Route("api/locations/allbycustomerid/{id}")]
        public HttpResponseMessage GetByCustomerId(long id)
        {
            var locations = _locationRepository.GetLocationByCustomerId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, locations);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/locations/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var locations = _locationRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, locations);
            return response;
        }


        [Route("api/locations")]
        public HttpResponseMessage Post(Location location)
        {
            var locations = _locationRepository.Save(location);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, locations);
            return response;
        }

        [Route("api/locations/update/{id}")]
        public HttpResponseMessage Put(Location location)
        {
            _locationRepository.SaveOrUpdate(location);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/locations/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _locationRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
