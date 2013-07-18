using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServices.DataAccessLayer.SQLDatabaseAccessServices;

namespace WCFServices.BusinessLogicLayer.UserManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        #region Login and Signup
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "SignUp"
            )]
        int SignUp(User user);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Login"
            )]
        User Login(User user);
        #endregion
    }

    [DataContract]
    public class User
    {
        [DataMember(Name = "UserID")]
        public int UserID
        {
            get;
            set;
        }

        [DataMember(Name = "Name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "GroupID")]
        public int GroupID
        {
            get;
            set;
        }

        [DataMember(Name = "Email")]
        public string Email
        {
            get;
            set;
        }

        [DataMember(Name = "Password")]
        public string Password
        {
            get;
            set;
        }

        [DataMember(Name = "Avatar")]
        public string Avatar
        {
            get;
            set;
        }

        [DataMember(Name = "UserTypeID")]
        public string UserTypeID
        {
            get;
            set;
        }

        [DataMember(Name = "GenderID")]
        public string GenderID
        {
            get;
            set;
        }

        [DataMember(Name = "AuthenticationTypeID")]
        public string AuthenticationTypeID
        {
            get;
            set;
        }
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
