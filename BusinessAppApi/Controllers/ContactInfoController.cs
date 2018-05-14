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
    public class ContactInfoController : ApiController
    {
        private readonly IContactInfoRepository _contactInfoRepository;

        public ContactInfoController(IContactInfoRepository contactInfoRepository)
        {
            _contactInfoRepository = contactInfoRepository;
        }

        // GET api/ptemployees
        [Route("api/contactinfo/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var contactInfos = _contactInfoRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactInfos);
            return response;
        }
        [Route("api/contactinfo/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var contactInfos = _contactInfoRepository.GetContactInfoByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactInfos);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/contactinfo/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var contactInfos = _contactInfoRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactInfos);
            return response;
        }


        [Route("api/contactinfo")]
        public HttpResponseMessage Post(ContactInfo contactInfo)
        {
            var contactInfos = _contactInfoRepository.Save(contactInfo);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactInfos);
            return response;
        }

        [Route("api/contactinfo/update/{id}")]
        public HttpResponseMessage Put(ContactInfo contactInfo)
        {
            _contactInfoRepository.SaveOrUpdate(contactInfo);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/contactinfo/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _contactInfoRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

    }
    
}
