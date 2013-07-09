using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Users" in code, svc and config file together.
    public class Users : IUsers
    {
        public DataTable GetUserDetail(int userId)
        {
            throw new NotImplementedException();
        }

        public int InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public int UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
