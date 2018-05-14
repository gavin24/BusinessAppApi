using BusinessApp.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusinessAppApi.Controllers
{
    public class PriceController : ApiController
    {
        private readonly IPriceRepository _priceRepository;

        public PriceController(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

      
    }
  
}
