﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
       
        public BillRepository(ISession session) : base(session)
       {
            
        }

       public List<Bill> GetBillsByClientId(long clientId)
       {
           throw new NotImplementedException();
       }
    }
}
