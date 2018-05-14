using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IUserService
    {
        User GetUserByEmail(string email);
        User GetUserByPhoneNumber(long phoneNumber);
        void Delete(long id);
        void SaveOrUpdate(User user);
        long Save(User user);
        IList<User> GetAllRecords();
        User Get(long id);
    }
}
