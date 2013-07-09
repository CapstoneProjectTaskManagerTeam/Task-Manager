using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Tasks" in code, svc and config file together.
    public class Tasks : ITasks
    {
        public DataTable GetTaskDetail(int taskid)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTaskbyUserID(int userId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTaskbyState(int stateId)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTaskbyProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public int InsertTask(Task task)
        {
            throw new NotImplementedException();
        }

        public int UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public int DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
