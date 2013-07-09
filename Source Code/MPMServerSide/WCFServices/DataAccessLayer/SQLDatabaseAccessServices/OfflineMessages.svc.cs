using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OfflineMessages" in code, svc and config file together.
    public class OfflineMessages : IOfflineMessages
    {
        public DataTable GetOfflineMessagebyReceiver(int receiver)
        {
            throw new NotImplementedException();
        }

        public int InsertOfflineMessage(OfflineMessage offlineMessage)
        {
            throw new NotImplementedException();
        }

        public int DeleteOfflineMessage(int offlineMessageId)
        {
            throw new NotImplementedException();
        }
    }
}
