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
   public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        
        public NotificationRepository(ISession session) : base(session)
       {
           
        }

       public List<Notification> GetAllNotificationsByClientId(long clientId)
       {
           throw new NotImplementedException();
       }

       public List<Notification> GetAllNotificationsByOrderId(long orderId)
       {
           throw new NotImplementedException();
       }

       public List<Notification> GetAllNotificationsByUserId(long userId)
       {
           throw new NotImplementedException();
       }
    }
}
