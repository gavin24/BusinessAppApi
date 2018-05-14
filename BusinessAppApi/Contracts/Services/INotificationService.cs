using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Services
{
   public interface INotificationService
    {
        List<Notification> GetAllNotificationsByClientId(long clientId);
        List<Notification> GetAllNotificationsByOrderId(long orderId);
        List<Notification> GetAllNotificationsByUserId(long userId);
        void Delete(long id);
        void SaveOrUpdate(Notification notification);
        long Save(Notification notification);
        IList<Notification> GetAllRecords();
        Notification Get(long id);
    }
}
