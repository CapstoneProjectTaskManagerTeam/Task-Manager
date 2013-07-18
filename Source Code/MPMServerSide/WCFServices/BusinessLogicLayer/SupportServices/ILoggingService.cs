using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogging" in both code and config file together.
    [ServiceContract]
    public interface ILoggingService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Send Log"
            )]
        void SendLog(Log log);
        #endregion
    }

    [DataContract]
    public class Log
    {
        #region Members
        [DataMember(Name = "LogID")]
        public int LogID
        {
            get;
            set;
        }

        [DataMember(Name = "Time")]
        public DateTime Time
        {
            get;
            set;
        }

        [DataMember(Name = "TAG")]
        public string TAG
        {
            get;
            set;
        }

        [DataMember(Name = "Actor")]
        public string Actor
        {
            get;
            set;
        }

        [DataMember(Name = "Method")]
        public string Method
        {
            get;
            set;
        }

        [DataMember(Name = "Type")]
        public string Type
        {
            get;
            set;
        }

        [DataMember(Name = "Description")]
        public string Description
        {
            get;
            set;
        }
        #endregion
    }
}
