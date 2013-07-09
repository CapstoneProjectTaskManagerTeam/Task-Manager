using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Project" in code, svc and config file together.
    public class Project : IProject
    {
        public List<Project> LoadProjectbyUser(int userid)
        {
            throw new NotImplementedException();
        }


        public int AddNewProject(Project project)
        {
            throw new NotImplementedException();
        }

        public bool IsValidProjectName(string projectName)
        {
            throw new NotImplementedException();
        }

        public int AddDefauleStateforProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
