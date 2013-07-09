using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccess;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices.TaskServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskOverdue" in both code and config file together.
    [ServiceContract]
    public interface ITaskOverdue
    {
        [OperationContract]
        List<Task> UpdateOverdue(List<Task> list);
    }
}
