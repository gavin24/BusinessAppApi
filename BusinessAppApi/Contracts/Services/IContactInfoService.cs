using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IContactInfoService
    {
        ContactInfo GetContactInfoByClientId(long clientId);
        void Delete(long id);
        void SaveOrUpdate(ContactInfo contactInfo);
        long Save(ContactInfo contactInfo);
        IList<ContactInfo> GetAllRecords();
        ContactInfo Get(long id);
    }
}
