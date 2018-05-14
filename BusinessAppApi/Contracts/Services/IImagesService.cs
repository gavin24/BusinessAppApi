using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IImagesService
    {
        Images GetImageByProductId(long productId);
        Images GetImageByClientId(long clientId);
        Images GetImageByUserId(long userId);
        void Delete(long id);
        void SaveOrUpdate(Images images);
        long Save(Images images);
        IList<Images> GetAllRecords();
        Images Get(long id);
    }
}
