using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccess
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStates" in both code and config file together.
    [ServiceContract]
    public interface IStates
    {
        [OperationContract]
        DataTable GetStatebyProject(int projectId);

        [OperationContract]
        int InsertState(State state);

        [OperationContract]
        int UpdateState(State state);

        [OperationContract]
        int DeleteState(int stateId);
    }

    [DataContract]
    public class State
    {
        [DataMember(Name = "StateID")]
        public int StateID
        {
            get;
            set;
        }

        [DataMember(Name = "StateName")]
        public string StateName
        {
            get;
            set;
        }

        [DataMember(Name = "Description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "ProjectID")]
        public int ProjectID
        {
            get;
            set;
        }

        [DataMember(Name = "StartDate")]
        public DateTime StartDate
        {
            get;
            set;
        }

        [DataMember(Name = "DueDate")]
        public DateTime DueDate
        {
            get;
            set;
        }
    }
}
