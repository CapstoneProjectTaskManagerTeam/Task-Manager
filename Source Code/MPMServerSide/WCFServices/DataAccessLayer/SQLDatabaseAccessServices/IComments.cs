using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IComments" in both code and config file together.
    [ServiceContract]
    public interface IComments
    {
        [OperationContract]
        DataTable GetCommentbyTaskID(int taskId);

        [OperationContract]
        int InsertComment(Comment comment);
    }

    [DataContract]
    public class Comment
    {
        [DataMember(Name = "CommentID")]
        public int CommentID
        {
            get;
            set;
        }

        [DataMember(Name = "Content")]
        public string Content
        {
            get;
            set;
        }

        [DataMember(Name = "UserID")]
        public int UserID
        {
            get;
            set;
        }

        [DataMember(Name = "TaskID")]
        public int TaskID
        {
            get;
            set;
        }
    }
}
