using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;

namespace BusinessApp.Services
{
   public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
       
       public User GetUserByEmail(string email)
       {
           return _userRepository.GetAllRecords("SELECT * FROM [User] WHERE Email = " + email).FirstOrDefault();
       }

       public User GetUserByPhoneNumber(long phoneNumber)
       {
            return _userRepository.GetAllRecords("SELECT * FROM [User] WHERE PhoneNumber = " + phoneNumber.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {

           _userRepository.Delete(id);
       }

       public void SaveOrUpdate(User user)
       {
          _userRepository.SaveOrUpdate(user);
       }

       public long Save(User user)
       {
          return _userRepository.Save(user);
       
       }

       public IList<User> GetAllRecords()
       {
           return _userRepository.GetAllRecords("SELECT * FROM [User]");
       }

       public User Get(long id)
       {
           return _userRepository.Get(id);
       }
    }
}
