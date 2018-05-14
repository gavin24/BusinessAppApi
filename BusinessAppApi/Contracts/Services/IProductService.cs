using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IProductService
    {
        List<Products> GetProductsByCategoryId(long categoryId);
        void Delete(long id);
        void SaveOrUpdate(Products products);
        long Save(Products products);
        IList<Products> GetAllRecords();
        Products Get(long id);
    }
}
