using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectService" in code, svc and config file together.
    public class ProjectService : IProjectService
    {
        public int AddNewProject(Project project)
        {
            throw new NotImplementedException();
        }

        public int DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public int UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectbyUser(int userId)
        {
            throw new NotImplementedException();
        }

        public int GenerateDefaultProject(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetMemberbyProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
