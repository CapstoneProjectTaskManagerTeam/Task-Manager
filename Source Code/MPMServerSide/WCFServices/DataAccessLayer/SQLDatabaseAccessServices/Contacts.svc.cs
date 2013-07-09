using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Contacts" in code, svc and config file together.
    public class Contacts : IContacts
    {
        public DataTable GetContactbyUser(int user01, int user02)
        {
            throw new NotImplementedException();
        }

        public int InsertContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int DeleteContact(int contactId)
        {
            throw new NotImplementedException();
        }
    }
}
