using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
   public interface IProductRepository : IRepository<Products>
    {
       List<Products> GetProductsByCategoryId(long categoryId);
   }
}
