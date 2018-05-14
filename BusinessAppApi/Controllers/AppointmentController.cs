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
    public class AppointmentController : ApiController
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        // GET api/ptemployees
        [Route("api/appointments/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var appointments = _appointmentRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, appointments);
            return response;
        }
        [Route("api/appointments/allbyuserid/{id}")]
        public HttpResponseMessage GetByUserId(long id)
        {
            var appointments = _appointmentRepository.GetAppointmentByUserId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, appointments);
            return response;
        }
        [Route("api/appointments/allbydates/{id}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            var appointments = _appointmentRepository.GetAppointmentByDate(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, appointments);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/appointments/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var appointments = _appointmentRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, appointments);
            return response;
        }


        [Route("api/appointments")]
        public HttpResponseMessage Post(Appointment appointment)
        {
            var appointments = _appointmentRepository.Save(appointment);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, appointments);
            return response;
        }

        [Route("api/appointments/update/{id}")]
        public HttpResponseMessage Put(Appointment appointment)
        {
            _appointmentRepository.SaveOrUpdate(appointment);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/appointments/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _appointmentRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
  
}
