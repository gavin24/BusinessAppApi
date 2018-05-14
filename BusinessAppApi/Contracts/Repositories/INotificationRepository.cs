using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Models;

namespace BusinessApp.Contracts.Repositories
{
  public  interface INotificationRepository : IRepository<Notification>
    {
      List<Notification> GetAllNotificationsByClientId(long clientId);
        List<Notification> GetAllNotificationsByOrderId(long orderId);
        List<Notification> GetAllNotificationsByUserId(long userId);
    }
}
