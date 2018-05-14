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
    public class NotificationController : ApiController
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationController(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        // GET api/ptemployees
        [Route("api/notifications/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var notifications = _notificationRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }
        [Route("api/notifications/allbyuserid/{id}")]
        public HttpResponseMessage GetByUserId (long id)
        {
            var notifications = _notificationRepository.GetAllNotificationsByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }
        [Route("api/notifications/allbyorderid/{id}")]
        public HttpResponseMessage GetByOrderId(long id)
        {
            var notifications = _notificationRepository.GetAllNotificationsByOrderId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }
        [Route("api/notifications/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var notifications = _notificationRepository.GetAllNotificationsByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/notifications/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var notifications = _notificationRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }


        [Route("api/notifications")]
        public HttpResponseMessage Post(Notification notification)
        {
            var notifications = _notificationRepository.Save(notification);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, notifications);
            return response;
        }

        [Route("api/notifications/update/{id}")]
        public HttpResponseMessage Put(Notification notification)
        {
            _notificationRepository.SaveOrUpdate(notification);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/notifications/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _notificationRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
 
}
