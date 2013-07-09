using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjects" in both code and config file together.
    [ServiceContract]
    public interface IProjects
    {
        [OperationContract]
        DataTable GetProjectDetail(int projectId);

        [OperationContract]
        DataTable GetProjectbyOwnerUser(int ownerUser);

        [OperationContract]
        int InsertProject(Project project);

        [OperationContract]
        int UpdateProject(Project project);

        int DeleteProject(int projetid);

    }

    [DataContract]
    public class Project 
    {
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
