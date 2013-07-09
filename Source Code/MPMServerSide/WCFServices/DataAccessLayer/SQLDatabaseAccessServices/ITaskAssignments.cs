using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskAssignments" in both code and config file together.
    [ServiceContract]
    public interface ITaskAssignments
    {
        [OperationContract]
        DataTable GetTaskAssignmentbyTaskID(int taskid);

        [OperationContract]
        DataTable GetTaskAssignmnetbyUserID(int userid);

        [OperationContract]
        int InsertTaskAssignmnet(TaskAssignmnet taskAssignmnet);

        [OperationContract]
        int DeleteTaskAssignmnet(int taskAssignmnetID);
    }

    public class TaskAssignmnet
    {
        [DataMember(Name = "TaskAssignmnetID")]
        public int TaskAssignmentID
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

        [DataMember(Name = "TaskID")]
        public int TaskID
        {
            get;
            set;
        }

    }
}
