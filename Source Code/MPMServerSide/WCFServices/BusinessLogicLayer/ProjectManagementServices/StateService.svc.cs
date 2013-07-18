using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StateService" in code, svc and config file together.
    public class StateService : IStateService
    {
        public int AddNewState(State state)
        {
            throw new NotImplementedException();
        }

        public int DeleteState(int stateId)
        {
            throw new NotImplementedException();
        }

        public int UpdateState(State state)
        {
            throw new NotImplementedException();
        }

        public List<State> GetStatebyProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
