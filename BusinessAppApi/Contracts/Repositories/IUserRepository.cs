using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IUserRepository : IRepository<User>
    {
       User GetUserByEmail(string email);
       User GetUserByPhoneNumber(long phoneNumber);
   }
}
