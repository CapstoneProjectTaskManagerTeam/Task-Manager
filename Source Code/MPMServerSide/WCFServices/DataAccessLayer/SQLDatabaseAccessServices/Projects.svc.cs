using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Projects" in code, svc and config file together.
    public class Projects : IProjects
    {
        public DataTable GetProjectDetail(int projectId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetProjectbyOwnerUser(int ownerUser)
        {
            throw new NotImplementedException();
        }

        public int InsertProject(Project project)
        {
            throw new NotImplementedException();
        }

        public int UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public int DeleteProject(int projetid)
        {
            throw new NotImplementedException();
        }
    }
}
