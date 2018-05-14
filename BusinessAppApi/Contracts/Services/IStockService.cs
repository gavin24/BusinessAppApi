using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface IStockService
    {
        Stock GetStockByProductId(long productId);
        void Delete(long id);
        void SaveOrUpdate(Stock stock);
        long Save(Stock stock);
        IList<Stock> GetAllRecords();
        Stock Get(long id);
    }
}
