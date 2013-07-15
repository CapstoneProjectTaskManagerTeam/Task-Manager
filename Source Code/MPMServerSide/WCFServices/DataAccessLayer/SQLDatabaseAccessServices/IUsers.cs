using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using WCFServices.BusinessLogicLayer.UserManagementServices;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsers" in both code and config file together.
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        DataTable SelectUser(User user);

        [OperationContract]
        int InsertUser(User user);

        [OperationContract]
        int UpdateUser(User user);

        [OperationContract]
        int DeleteUser(int userId);
    }
    
}
