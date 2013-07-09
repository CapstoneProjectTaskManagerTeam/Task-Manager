using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Comments" in code, svc and config file together.
    public class Comments : IComments
    {
        public DataTable GetCommentbyTaskID(int taskId)
        {
            throw new NotImplementedException();
        }

        public int InsertComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
