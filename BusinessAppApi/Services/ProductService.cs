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
   public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

       public List<Products> GetProductsByCategoryId(long categoryId)
       {
            return _productRepository.GetAllRecords("SELECT * FROM [Products] WHERE CatergoryId = " + categoryId.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _productRepository.Delete(id);
       }

       public void SaveOrUpdate(Products products)
       {
            _productRepository.SaveOrUpdate(products);
       }

       public long Save(Products products)
       {
          return _productRepository.Save(products);
       }

       public IList<Products> GetAllRecords()
       {
            return _productRepository.GetAllRecords("SELECT * FROM [Products]");
        }

       public Products Get(long id)
       {
         return  _productRepository.Get(id);
       }
    }
}
