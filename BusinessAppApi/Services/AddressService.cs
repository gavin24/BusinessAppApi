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
   public class AddressService:IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;

        }

       public Address GetAddressByUserId(long userId)
       {
            return _addressRepository.GetAllRecords("SELECT * FROM [Address] WHERE ClientId = " + userId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _addressRepository.Delete(id);
       }

       public void SaveOrUpdate(Address address)
       {
            _addressRepository.SaveOrUpdate(address);
       }

       public long Save(Address address)
       {
           return _addressRepository.Save(address);
       }

       public IList<Address> GetAllRecords()
       {
            return _addressRepository.GetAllRecords("SELECT * FROM [Address]");
        }

       public Address Get(long id)
       {
           return _addressRepository.Get(id);
       }
    }
}
