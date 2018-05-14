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
    public class ClientController : ApiController
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET api/ptemployees
        [Route("api/clients/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var clients = _clientRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, clients);
            return response;
        }
        [Route("api/clients/allbynumber/{id}")]
        public HttpResponseMessage GetByPhoneNumber(long id)
        {
            var clients = _clientRepository.GetClientByPhoneNumber(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, clients);
            return response;
        }
        [Route("api/clients/allbyuseremail/{id}")]
        public HttpResponseMessage GetUserByEmail(string email)
        {
            var clients = _clientRepository.GetClientByEmail(email);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, clients);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/clients/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var clients = _clientRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, clients);
            return response;
        }


        [Route("api/clients")]
        public HttpResponseMessage Post(Client client)
        {
            var clients = _clientRepository.Save(client);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, clients);
            return response;
        }

        [Route("api/clients/update/{id}")]
        public HttpResponseMessage Put(Client client)
        {
            _clientRepository.SaveOrUpdate(client);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/clients/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _clientRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
