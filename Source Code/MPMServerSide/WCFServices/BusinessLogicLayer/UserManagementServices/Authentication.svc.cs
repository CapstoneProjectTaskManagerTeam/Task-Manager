using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.UserManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Authentication" in code, svc and config file together.
    public class Authentication : IAuthentication
    {
        public int Login(DataAccessLayer.SQLDatabaseAccess.User user)
        {
            throw new NotImplementedException();
        }
    }
}
