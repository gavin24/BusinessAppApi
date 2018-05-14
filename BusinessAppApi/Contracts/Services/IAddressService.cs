using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IAddressService
    {
        Address GetAddressByUserId(long userId);
        void Delete(long id);
        void SaveOrUpdate(Address address);
        long Save(Address address);
        IList<Address> GetAllRecords();
        Address Get(long id);
    }
}
