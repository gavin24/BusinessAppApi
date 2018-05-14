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
    public class ImagesController : ApiController
    {
        private readonly IImagesRepository _imagesRepository;

        public ImagesController(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        // GET api/ptemployees
        [Route("api/images/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var imageList = _imagesRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }
        [Route("api/images/allbyuserid/{id}")]
        public HttpResponseMessage GetByUserId(long id)
        {
            var imageList = _imagesRepository.GetImageByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }
        [Route("api/images/allbyproductid/{id}")]
        public HttpResponseMessage GetByProductId(long id)
        {
            var imageList = _imagesRepository.GetImageByProductId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }
        [Route("api/images/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var imageList = _imagesRepository.GetImageByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/images/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var imageList = _imagesRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }


        [Route("api/images")]
        public HttpResponseMessage Post(Images images)
        {
            var imageList = _imagesRepository.Save(images);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, imageList);
            return response;
        }

        [Route("api/images/update/{id}")]
        public HttpResponseMessage Put(Images images)
        {
            _imagesRepository.SaveOrUpdate(images);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/images/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _imagesRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

    }
   
}
