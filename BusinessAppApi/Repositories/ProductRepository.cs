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
   public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
     
        public ProductRepository(ISession session) : base(session)
       {
          
        }

       public List<Products> GetProductsByCategoryId(long categoryId)
       {
           throw new NotImplementedException();
       }
    }
}
