using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaskAssignments" in both code and config file together.
    [ServiceContract]
    public interface ITaskAssignments
    {
        [OperationContract]
        void DoWork();
    }
}
