using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OfflineNotifications" in code, svc and config file together.
    public class OfflineNotifications : IOfflineNotifications
    {
        public DataTable GetOfflineNotificationbyUserID(int userId)
        {
            throw new NotImplementedException();
        }

        public int InsertOfflineNotification(OfflineNotification offlineNotification)
        {
            throw new NotImplementedException();
        }

        public int UpdateOfflineNotification(OfflineNotification offlineNotification)
        {
            throw new NotImplementedException();
        }

        public int DeleteOfflineNotification(int offlineNotificationId)
        {
            throw new NotImplementedException();
        }
    }
}
