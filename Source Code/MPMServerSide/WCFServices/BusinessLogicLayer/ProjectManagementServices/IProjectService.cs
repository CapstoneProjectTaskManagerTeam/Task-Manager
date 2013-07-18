using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectService" in both code and config file together.
    [ServiceContract]
    public interface IProjectService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Add New Project"
            )]
        int AddNewProject(Project project);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Delete Project"
            )]
        int DeleteProject(int projectId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Update Project"
            )]
        int UpdateProject(Project project);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Project by User"
            )]
        List<Project> GetProjectbyUser(int userId);

        [OperationContract]
        int GenerateDefaultProject(int userId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Get Member by Project"
            )]
        List<Member> GetMemberbyProject(int projectId);
        #endregion
    }

    [DataContract]
    public class Project
    {
        #region DataMembers
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

        [DataMember(Name = "Description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "OwnerUser")]
        public int OwnerUser
        {
            get;
            set;
        }

        [DataMember(Name = "IsOwner")]
        public int IsOwner
        {
            get;
            set;
        }

        [DataMember(Name = "MemberList")]
        public List<Member> MemberList
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
    public class Member
    {
        #region DataMembers
        [DataMember(Name = "JoinProjectID")]
        public int JoinProjectID
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

        [DataMember(Name = "RoleID")]
        public int RoleID
        {
            get;
            set;
        }

        [DataMember(Name = "RoleName")]
        public string RoleName
        {
            get;
            set;
        }
        #endregion
    }

}
