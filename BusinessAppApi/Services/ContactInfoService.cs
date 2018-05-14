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
   public class ContactInfoService:IContactInfoService
    {
        private readonly IContactInfoRepository _contactInfoRepository;
        public ContactInfoService(IContactInfoRepository contactInfoRepository)
        {
            _contactInfoRepository = contactInfoRepository;

        }

       public ContactInfo GetContactInfoByClientId(long clientId)
       {
            return _contactInfoRepository.GetAllRecords("SELECT * FROM [ContactInfo] WHERE ClientId = " + clientId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _contactInfoRepository.Delete(id);
       }

       public void SaveOrUpdate(ContactInfo contactInfo)
       {
            _contactInfoRepository.SaveOrUpdate(contactInfo);
       }

       public long Save(ContactInfo contactInfo)
       {
           return _contactInfoRepository.Save(contactInfo);
       }

       public IList<ContactInfo> GetAllRecords()
       {
            return _contactInfoRepository.GetAllRecords("SELECT * FROM [ContactInfo]");
        }

       public ContactInfo Get(long id)
       {
           return _contactInfoRepository.Get(id);
       }
    }
}
