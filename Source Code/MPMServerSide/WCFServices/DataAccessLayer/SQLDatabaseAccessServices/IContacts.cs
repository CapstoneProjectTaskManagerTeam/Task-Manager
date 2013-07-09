using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContacts" in both code and config file together.
    [ServiceContract]
    public interface IContacts
    {
        [OperationContract]
        DataTable GetContactbyUser(int user01, int user02);

        [OperationContract]
        int InsertContact(Contact contact);

        [OperationContract]
        int DeleteContact(int contactId);
    }

    [DataContract]
    public class Contact 
    {
        [DataMember(Name = "ContactID")]
        public int ContactId
        {
            get;
            set;
        }

        [DataMember(Name = "User01")]
        public int User01
        {
            get;
            set;
        }

        [DataMember(Name = "User02")]
        public int User02
        {
            get;
            set;
        }
    }
}
