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
   public class CategoriesRepository : BaseRepository<Categories>, ICategoriesRepository
    {
       
        public CategoriesRepository(ISession session) : base(session)
       {
           
        }
    }
}
