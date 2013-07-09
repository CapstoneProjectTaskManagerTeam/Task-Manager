using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITasks" in both code and config file together.
    [ServiceContract]
    public interface ITasks
    {
        [OperationContract]
        DataTable GetTaskDetail(int taskid);

        [OperationContract]
        DataTable GetTaskbyUserID(int userId);

        [OperationContract]
        DataTable GetTaskbyState(int stateId);

        [OperationContract]
        DataTable GetTaskbyProject(int projectId);

        [OperationContract]
        int InsertTask(Task task);

        [OperationContract]
        int UpdateTask(Task task);

        [OperationContract]
        int DeleteTask(int taskId);
    }

    [DataContract]
    public class Task
    {
        [DataMember(Name = "TaskID")]
        public int TaskID
        {
            get;
            set;
        }

        [DataMember(Name = "TaskName")]
        public string TaskName
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

        [DataMember(Name = "StateID")]
        public int StateID
        {
            get;
            set;
        }

        [DataMember(Name = "ProjectID")]
        public int ProjectID
        {
            get;
            set;
        }

        [DataMember(Name = "Comments")]
        public int Comments
        {
            get;
            set;
        }

        [DataMember(Name = "Status")]
        public string Status
        {
            get;
            set;
        }

        [DataMember(Name = "StartDate")]
        public DateTime StartDate
        {
            get;
            set;
        }

        [DataMember(Name = "DueDate")]
        public DateTime DueDate
        {
            get;
            set;
        }

    }
}