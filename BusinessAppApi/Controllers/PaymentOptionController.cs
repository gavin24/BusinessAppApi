using BusinessApp.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusinessAppApi.Controllers
{
    public class PaymentOptionController : ApiController
    {
        private readonly IPaymentOptionRepository _paymentOptionRepository;

        public PaymentOptionController(IPaymentOptionRepository paymentOptionRepository)
        {
            _paymentOptionRepository = paymentOptionRepository;
        }

    }
  
}
