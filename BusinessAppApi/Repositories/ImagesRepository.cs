using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class ImagesRepository : BaseRepository<Images>, IImagesRepository
    {
       
        public ImagesRepository(ISession session) : base(session)
       {
           
        }

       public Images GetImageByProductId(long productId)
       {
           throw new NotImplementedException();
       }

       public Images GetImageByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public Images GetImageByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
