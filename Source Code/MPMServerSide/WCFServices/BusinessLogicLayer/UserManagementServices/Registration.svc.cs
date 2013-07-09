using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccess;

namespace WCFServices.BusinessLogicLayer.UserManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Registration" in code, svc and config file together.
    public class Registration : IRegistration
    {
        public int SignUp(User user)
        {
            throw new NotImplementedException();
        }

        public bool IsValidUser(string name, string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsValidName(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsValidEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool IsValidPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
