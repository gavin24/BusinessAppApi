using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Models;

namespace BusinessApp.Services
{
   public class ImagesService:IImagesService
    {
        private readonly IImagesRepository _imagesRepository;
        public ImagesService(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;

        }

       public Images GetImageByProductId(long productId)
       {
            return _imagesRepository.GetAllRecords("SELECT * FROM [Images] WHERE UserId = " + productId.ToString()).FirstOrDefault();
        }

       public Images GetImageByClientId(long clientId)
       {
            return _imagesRepository.GetAllRecords("SELECT * FROM [Images] WHERE ClientId = " + clientId.ToString()).FirstOrDefault();
        }

       public Images GetImageByUserId(long userId)
       {
            return _imagesRepository.GetAllRecords("SELECT * FROM [Images] WHERE UserId = " + userId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _imagesRepository.Delete(id);
       }

       public void SaveOrUpdate(Images images)
       {
            _imagesRepository.SaveOrUpdate(images);
       }

       public long Save(Images images)
       {
           return _imagesRepository.Save(images);
       }

       public IList<Images> GetAllRecords()
       {
            return _imagesRepository.GetAllRecords("SELECT * FROM [Images]");
        }

       public Images Get(long id)
       {
           return _imagesRepository.Get(id);
       }
    }
}
