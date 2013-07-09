using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskAssignments" in code, svc and config file together.
    public class TaskAssignments : ITaskAssignments
    {
        public DataTable GetTaskAssignmentbyTaskID(int taskid)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTaskAssignmnetbyUserID(int userid)
        {
            throw new NotImplementedException();
        }

        public int InsertTaskAssignmnet(TaskAssignmnet taskAssignmnet)
        {
            throw new NotImplementedException();
        }

        public int DeleteTaskAssignmnet(int taskAssignmnetID)
        {
            throw new NotImplementedException();
        }
    }
}
