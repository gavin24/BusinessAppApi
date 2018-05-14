using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IClientService
    {
        Client GetClientByEmail(string email);
        Client GetClientByPhoneNumber(long phoneNumber);
        void Delete(long id);
        void SaveOrUpdate(Client client);
        long Save(Client client);
        IList<Client> GetAllRecords();
        Client Get(long id);
    }
}
