using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOfflineMessages" in both code and config file together.
    [ServiceContract]
    public interface IOfflineMessages
    {
        [OperationContract]
        DataTable GetOfflineMessagebyReceiver(int receiver);

        [OperationBehavior]
        int InsertOfflineMessage(OfflineMessage offlineMessage);

        [OperationContract]
        int DeleteOfflineMessage(int offlineMessageId);
    }

    [DataContract]
    public class OfflineMessage
    {
        [DataMember(Name = "OfflineMessageID")]
        public int OfflineMessageID
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
    }
}
