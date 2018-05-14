using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using NHibernate;

namespace BusinessApp.Repositories
{
   public class BaseRepository<T> : IRepository<T> where T : Model
    {
        
        private readonly ISession _session;

        public BaseRepository(ISession session)
        {
            _session = session;
        }

        public ISession Session
        {
            get
            {
                return _session;
            }
        }
        public T Get(long id)
        {
            return Session.Get<T>(Convert.ToInt64(id));
        }

        public void SaveOrUpdate(T item)
        {
            Session.SaveOrUpdate(item);
        }

        public void Delete(long id)
        {
            Session.Delete(id);
        }

  
        public IList<T> GetAllRecords(string query)
        {
            return Session.CreateQuery(query).List<T>();
        }

        public long Save(T entity)
        {
            return Convert.ToInt64(Session.Save(entity));
        }
        //public void SaveOrUpdate(T item)
        //{
        //    Session.SaveOrUpdate(item);
        //}

        //public void Delete(T item)
        //{
        //    Session.Delete(item);
        //}





    }
}
