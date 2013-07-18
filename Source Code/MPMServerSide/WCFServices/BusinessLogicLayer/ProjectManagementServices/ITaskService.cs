using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskService" in both code and config file together.
    [ServiceContract]
    public interface ITaskService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Add new Task"
            )]
        int AddNewTask(Task task);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Delete Task"
            )]
        int DeleteTask(int taskId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Update Task"
            )]
        int UpdateTask(Task task);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Task by User"
            )]
        List<Task> GetTaskbyUser(int userId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check Task OverDue"
            )]
        void CheckTaskOverDue(int userId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Task by Project"
            )]
        List<Task> GetTaskbyProject(int projectid);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Task by State"
            )]
        List<Task> GetTaskbyState(int stateId);

        [OperationContract]
        List<Task> UpdateTaskStatus(List<Task> list);

        [OperationContract]
        void UpdateTimePlan(int taskId, DateTime startDate, DateTime dueDate);
        #endregion

    }

    [DataContract]
    public class Task
    {
        #region DataMembers
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

        [DataMember(Name = "StateName")]
        public string StateName
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

        [DataMember(Name = "ProjectName")]
        public string ProjectName
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

        [DataMember(Name = "AssignmentList")]
        public List<TaskAssignmnet> AssignmentList
        {
            get;
            set;
        }

        [DataMember(Name = "CommentList")]
        public List<Comment> CommentList
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
        #endregion
    }

    [DataContract]
    public class TaskAssignmnet
    {
        #region DataMembers
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

        [DataMember(Name = "Avatar")]
        public string Avatar
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
        #endregion
    }

    [DataContract]
    public class Comment
    {
        #region DataMembers
        [DataMember(Name = "CommentID")]
        public int CommentID
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

        [DataMember(Name = "UserID")]
        public int UserID
        {
            get;
            set;
        }

        [DataMember(Name = "Name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "Avatar")]
        public string Avatar
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
        #endregion
    }
}