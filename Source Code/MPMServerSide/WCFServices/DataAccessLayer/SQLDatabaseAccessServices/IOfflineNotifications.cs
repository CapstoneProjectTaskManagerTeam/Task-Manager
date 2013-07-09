


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOfflineNotifications" in both code and config file together.
    [ServiceContract]
    public interface IOfflineNotifications
    {
        [OperationContract]
        DataTable GetOfflineNotificationbyUserID(int userId);

        [OperationContract]
        int InsertOfflineNotification(OfflineNotification offlineNotification);

        [OperationContract]
        int UpdateOfflineNotification(OfflineNotification offlineNotification);

        [OperationContract]
        int DeleteOfflineNotification(int offlineNotificationId);
    }

    [DataContract]
    public class OfflineNotification
    {
        [DataMember(Name = "OfflineNotificationID")]
        public int OfflineNotificationID
        {
            get;
            set;
        }

        public int NotificationID
        {
            get;
            set;
        }

        public int UserID
        {
            get;
            set;
        }
    }
}
