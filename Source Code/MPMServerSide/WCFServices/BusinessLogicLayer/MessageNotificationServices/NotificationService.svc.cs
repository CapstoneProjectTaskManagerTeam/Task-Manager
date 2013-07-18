using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.MessageNotificationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NotificationService" in code, svc and config file together.
    public class NotificationService : INotificationService
    {
        public int SendNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public int AddNewNotification(Notification Notification)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetNotificationbyUser(int userId)
        {
            throw new NotImplementedException();
        }

        public int DeleteNotification(int notificationId)
        {
            throw new NotImplementedException();
        }
    }
}
