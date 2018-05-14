using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IImagesRepository : IRepository<Images>
    {
       Images GetImageByProductId(long productId);
        Images GetImageByClientId(long clientId);
        Images GetImageByUserId(long userId);
    }
}
