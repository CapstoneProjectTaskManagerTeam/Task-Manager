using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccess;

namespace WCFServices.BusinessLogicLayer.UserManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegistration" in both code and config file together.
    [ServiceContract]
    public interface IRegistration
    {
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "SignUp",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json
            )]
        int SignUp(User user);

        [OperationContract]
        bool IsValidUser(string name, string email, string password);

        [OperationContract]
        bool IsValidName(string name);

        [OperationContract]
        bool IsValidEmail(string email);

        [OperationContract]
        bool IsValidPassword(string password);
    }
}
