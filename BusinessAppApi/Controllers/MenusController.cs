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
    public class MenusController : ApiController
    {
        private readonly IMenusRepository _menusRepository;

        public MenusController(IMenusRepository menusRepository)
        {
            _menusRepository = menusRepository;
        }

        // GET api/ptemployees
     
    }
  
}
