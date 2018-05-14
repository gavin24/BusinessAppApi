using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IAddressRepository : IRepository<Address>
    {
        Address GetAddressByUserId(long userId);
    }
}
