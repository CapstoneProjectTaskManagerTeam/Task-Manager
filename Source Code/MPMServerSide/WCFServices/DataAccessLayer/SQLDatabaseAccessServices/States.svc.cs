using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "States" in code, svc and config file together.
    public class States : IStates
    {
        public DataTable GetStatebyProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public int InsertState(State state)
        {
            throw new NotImplementedException();
        }

        public int UpdateState(State state)
        {
            throw new NotImplementedException();
        }

        public int DeleteState(int stateId)
        {
            throw new NotImplementedException();
        }
    }
}
