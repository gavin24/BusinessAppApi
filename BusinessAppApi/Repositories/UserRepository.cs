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
   public class UserRepository : BaseRepository<User>, IUserRepository
    {
      
        public UserRepository(ISession session) : base(session)
       {
          
        }

       public User GetUserByEmail(string email)
       {
           throw new NotImplementedException();
       }

       public User GetUserByPhoneNumber(long phoneNumber)
       {
           throw new NotImplementedException();
       }
    }
}
