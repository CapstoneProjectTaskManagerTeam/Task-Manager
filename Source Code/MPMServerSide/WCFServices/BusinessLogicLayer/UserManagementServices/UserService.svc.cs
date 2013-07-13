using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccess;

namespace WCFServices.BusinessLogicLayer.UserManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    public class UserService : IUserService
    {

        public int SignUp(User user)
        {
            throw new NotImplementedException();
        }

        public int Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
