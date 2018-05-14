using System;
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
   public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        
        public ClientRepository(ISession session) : base(session)
       {
            
        }

       public Client GetClientByEmail(string email)
       {
           throw new NotImplementedException();
       }

       public Client GetClientByPhoneNumber(long phoneNumber)
       {
           throw new NotImplementedException();
       }
    }
}
