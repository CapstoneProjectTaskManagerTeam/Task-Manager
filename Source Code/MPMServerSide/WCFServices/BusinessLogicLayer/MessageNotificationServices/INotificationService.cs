using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.MessageNotificationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INotificationService" in both code and config file together.
    [ServiceContract]
    public interface INotificationService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Send Notification"
            )]
        int SendNotification(Notification notification);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Add New Notification"
            )]
        int AddNewNotification(Notification Notification);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Notification by User"
            )]
        List<Notification> GetNotificationbyUser(int userId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Delete Notification"
            )]
        int DeleteNotification(int notificationId);
        #endregion

    }

    [DataContract]
    public class Notification
    {
        #region DataMembers
        [DataMember(Name = "NotificationID")]
        public int NotificationID
        {
            get;
            set;
        }

        [DataMember(Name = "UserID")]
        public int UserID
        {
            get;
            set;
        }

        [DataMember(Name = "Content")]
        public string Content
        {
            get;
            set;
        }

        [DataMember(Name = "ShortContent")]
        public string ShortContent
        {
            get;
            set;
        }
        #endregion
    }
}
