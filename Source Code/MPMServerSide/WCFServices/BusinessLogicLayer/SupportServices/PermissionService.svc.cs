using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PermissionChecking" in code, svc and config file together.
    public class PermissionService : IPermissionService
    {
        public int CheckAddProjectPermisson(int userid)
        {
            throw new NotImplementedException();
        }

        public int CheckStatePermission(int userid, int projectId)
        {
            throw new NotImplementedException();
        }

        public int CheckTaskPermission(int userId, int taskId, int projectId)
        {
            throw new NotImplementedException();
        }

        public int CheckMemberPermission(int userId, int projectId)
        {
            throw new NotImplementedException();
        }

        public int CheckCommentPermission(int userId, int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
