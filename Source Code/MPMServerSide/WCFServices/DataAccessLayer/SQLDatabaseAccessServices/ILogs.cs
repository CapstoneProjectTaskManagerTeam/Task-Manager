using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogs" in both code and config file together.
    [ServiceContract]
    public interface ILogs
    {
        [OperationContract]
        int InsertLog(Log log);
    }

    [DataContract]
    public class Log
    {
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
        
    }
}
