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
   public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;

        }

       public Client GetClientByEmail(string email)
       {
            return _clientRepository.GetAllRecords("SELECT * FROM [Client] WHERE Email = " + email).FirstOrDefault();
        }

       public Client GetClientByPhoneNumber(long phoneNumber)
       {
            return _clientRepository.GetAllRecords("SELECT * FROM [Client] WHERE PhoneNumber = " + phoneNumber.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
           _clientRepository.Delete(id);
       }

       public void SaveOrUpdate(Client client)
       {
           _clientRepository.SaveOrUpdate(client);
       }

       public long Save(Client client)
       {
           return _clientRepository.Save(client);
       }

       public IList<Client> GetAllRecords()
       {
            return _clientRepository.GetAllRecords("SELECT * FROM [Client]");
        }

       public Client Get(long id)
       {
           return _clientRepository.Get(id);
       }
    }
}
