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
    public class AddressController : ApiController
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        // GET api/ptemployees
        [Route("api/address/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var address = _addressRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, address);
            return response;
        }
        [Route("api/address/allbyuserid/{id}")]
        public HttpResponseMessage GetByUserId(long id)
        {
            var address = _addressRepository.GetAddressByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, address);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/address/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var address = _addressRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, address);
            return response;
        }


        [Route("api/address")]
        public HttpResponseMessage Post(Address address)
        {
            var addresses = _addressRepository.Save(address);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, addresses);
            return response;
        }

        [Route("api/address/update/{id}")]
        public HttpResponseMessage Put(Address address)
        {
            _addressRepository.SaveOrUpdate(address);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/address/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _addressRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
    
}
