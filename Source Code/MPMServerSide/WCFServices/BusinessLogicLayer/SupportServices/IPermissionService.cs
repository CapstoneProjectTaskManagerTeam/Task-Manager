using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPermissionChecking" in both code and config file together.
    [ServiceContract]
    public interface IPermissionService
    {
        [OperationContract]
        bool CheckAdminPermssion(int userid);
    }
}
