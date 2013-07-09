using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JoinProjects" in code, svc and config file together.
    public class JoinProjects : IJoinProjects
    {
        public DataTable GetJoinProjectbyUserID(int userId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetJoinProjectbyProjectID(int projectId)
        {
            throw new NotImplementedException();
        }

        public int InsertJoinProject(JoinProject joinProject)
        {
            throw new NotImplementedException();
        }

        public int DeleteJoinProject(JoinProject joinProject)
        {
            throw new NotImplementedException();
        }
    }
}
