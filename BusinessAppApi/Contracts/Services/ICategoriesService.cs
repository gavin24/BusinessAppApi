using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface ICategoriesService
    { 
    
        void Delete(long id);
        void SaveOrUpdate(Categories cat);
        long Save(Categories cat);
        IList<Categories> GetAllRecords();
        Categories Get(long id);
    }
}
