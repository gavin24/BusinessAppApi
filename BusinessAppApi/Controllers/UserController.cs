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
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/ptemployees
        [Route("api/user/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var users = _userRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        [Route("api/user/allbynumberid/{id}")]
        public HttpResponseMessage GetByPhoneNumber(long id)
        {
            var users = _userRepository.GetUserByPhoneNumber(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        [Route("api/user/allbyemailid/{id}")]
        public HttpResponseMessage GetByEmail(string email)
        {
            var users = _userRepository.GetUserByEmail(email);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/user/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var users = _userRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }


        [Route("api/user")]
        public HttpResponseMessage Post(User user)
        {
            var users = _userRepository.Save(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        [Route("api/user/update/{id}")]
        public HttpResponseMessage Put(User user)
        {
            _userRepository.SaveOrUpdate(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/user/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _userRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
 
}
