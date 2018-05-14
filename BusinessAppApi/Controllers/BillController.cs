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
    public class BillController : ApiController
    {
        private readonly IBillRepository _billRepository;

        public BillController(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }


        // GET api/ptemployees
        [Route("api/bills/all/{query}")]
        public HttpResponseMessage GetAll(string query)
        {
            var bills = _billRepository.GetAllRecords(query);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bills);
            return response;
        }
        [Route("api/bills/allbyclientid/{id}")]
        public HttpResponseMessage GetByClientId(long id)
        {
            var bills = _billRepository.GetBillsByClientId(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bills);
            return response;
        }
        // GET api/ptemployees/5
        [Route("api/bills/get/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var bills = _billRepository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bills);
            return response;
        }


        [Route("api/bills")]
        public HttpResponseMessage Post(Bill bill)
        {
            var bills = _billRepository.Save(bill);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bills);
            return response;
        }

        [Route("api/bills/update/{id}")]
        public HttpResponseMessage Put(Bill bill)
        {
            _billRepository.SaveOrUpdate(bill);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [Route("api/bills/delete/{id}")]
        public HttpResponseMessage Delete(long id)
        {
            _billRepository.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
   
}
