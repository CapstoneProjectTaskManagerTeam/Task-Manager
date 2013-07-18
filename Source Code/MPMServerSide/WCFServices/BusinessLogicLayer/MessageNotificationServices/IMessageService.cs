using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.MessageNotificationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMessageService" in both code and config file together.
    [ServiceContract]
    public interface IMessageService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Send Message"
            )]
        int SendMessage(Message message);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Add New Message"
            )]
        int AddNewMessage(Message message);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Message by User"
            )]
        List<Message> GetMessagebyUser(int userId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Delete Message"
            )]
        int DeleteMessage(int messageId);
        #endregion
    }

    [DataContract]
    public class Message
    {
        #region DataMembers
        [DataMember(Name = "MessageID")]
        public int MessageID
        {
            get;
            set;
        }

        [DataMember(Name = "Sender")]
        public int Sender
        {
            get;
            set;
        }

        [DataMember(Name = "Receiver")]
        public int Receiver
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
