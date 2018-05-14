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
   public class CatergoriesService:ICategoriesService
    {
        private readonly ICategoriesRepository _caategoriesRepository;
        public CatergoriesService(ICategoriesRepository cartegoriesRepository)
        {
            _caategoriesRepository = cartegoriesRepository;

        }

       public void Delete(long id)
       {
            _caategoriesRepository.Delete(id);
       }

       public void SaveOrUpdate(Categories cat)
       {
            _caategoriesRepository.SaveOrUpdate(cat);
       }

       public long Save(Categories cat)
       {
           return _caategoriesRepository.Save(cat);
       }

       public IList<Categories> GetAllRecords()
       {
           return _caategoriesRepository.GetAllRecords("SELECT * FROM [Categories]");
       }

       public Categories Get(long id)
       {
          return _caategoriesRepository.Get(id);
       }
    }
}
