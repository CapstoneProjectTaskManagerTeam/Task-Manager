using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPermissionChecking" in both code and config file together.
    [ServiceContract]
    public interface IPermissionService
    {
        #region Operations
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check Add Project Permission"
            )]
        int CheckAddProjectPermisson(int userid);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check State Permission"
            )]
        int CheckStatePermission(int userid, int projectId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check Task Permisson"
            )]
        int CheckTaskPermission(int userId, int taskId, int projectId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check Edit Task Permisson"
            )]
        int CheckMemberPermission(int userId, int projectId);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Check Comment Task Permisson"
            )]
        int CheckCommentPermission(int userId, int taskId);
        #endregion
    }
}
