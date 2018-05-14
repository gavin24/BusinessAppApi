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
   public class StockService:IStockService
    {
        private readonly IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;

        }

       public Stock GetStockByProductId(long productId)
        {
          return  _stockRepository.GetAllRecords("SELECT * FROM [Stock] WHERE ProductId = " + productId.ToString()).FirstOrDefault();
        }

       public void Delete(long id)
       {
            _stockRepository.Delete(id);
        }

       public void SaveOrUpdate(Stock stock)
       {
            _stockRepository.SaveOrUpdate(stock);
       }

       public long Save(Stock stock)
       {
          return  _stockRepository.Save(stock);
        }

       public IList<Stock> GetAllRecords()
        {
           return _stockRepository.GetAllRecords("SELECT * FROM [Stock]");
        }

       public Stock Get(long id)
       {
          return _stockRepository.Get(id);
         
       }
    }
}
