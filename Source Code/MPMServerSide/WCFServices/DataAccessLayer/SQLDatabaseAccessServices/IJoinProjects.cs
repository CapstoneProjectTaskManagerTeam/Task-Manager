using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJoinProjects" in both code and config file together.
    [ServiceContract]
    public interface IJoinProjects
    {
        [OperationContract]
        DataTable GetJoinProjectbyUserID(int userId);

        [OperationContract]
        DataTable GetJoinProjectbyProjectID(int projectId);

        [OperationContract]
        int InsertJoinProject(JoinProject joinProject);

        [OperationContract]
        int DeleteJoinProject(JoinProject joinProject);
    }

    [DataContract]
    public class JoinProject
    {
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

        [DataMember(Name = "RoleID")]
        public int RoleID
        {
            get;
            set;
        }
    }
}
