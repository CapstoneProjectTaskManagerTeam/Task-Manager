using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccess;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices.TaskServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskOverdue" in code, svc and config file together.
    public class TaskOverdue : ITaskOverdue
    {
        public List<Task> UpdateOverdue(List<Task> list)
        {
            throw new NotImplementedException();
        }
    }
}
