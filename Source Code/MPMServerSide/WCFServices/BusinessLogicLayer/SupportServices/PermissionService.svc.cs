using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PermissionChecking" in code, svc and config file together.
    public class PermissionService : IPermissionService
    {
        public bool CheckAdminPermssion(int userid)
        {
            throw new NotImplementedException();
        }
    }
}
