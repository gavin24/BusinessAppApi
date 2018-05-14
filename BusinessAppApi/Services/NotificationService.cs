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
   public class NotificationService:INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;

        }

       public List<Notification> GetAllNotificationsByClientId(long clientId)
       {
            return _notificationRepository.GetAllRecords("SELECT * FROM [Notification] WHERE ClientId = " + clientId.ToString()).ToList();
        }

       public List<Notification> GetAllNotificationsByOrderId(long orderId)
       {
            return _notificationRepository.GetAllRecords("SELECT * FROM [Notification] WHERE OrderId = " + orderId.ToString()).ToList();
        }

       public List<Notification> GetAllNotificationsByUserId(long userId)
       {
            return _notificationRepository.GetAllRecords("SELECT * FROM [Notification] WHERE UserId = " + userId.ToString()).ToList();
        }

       public void Delete(long id)
       {
            _notificationRepository.Delete(id);
       }

       public void SaveOrUpdate(Notification notification)
       {
           _notificationRepository.SaveOrUpdate(notification);
       }

       public long Save(Notification notification)
       {
           return _notificationRepository.Save(notification);
       }

       public IList<Notification> GetAllRecords()
       {
            return _notificationRepository.GetAllRecords("SELECT * FROM [Notification]");
        }

       public Notification Get(long id)
       {
           return _notificationRepository.Get(id);
       }
    }
}
