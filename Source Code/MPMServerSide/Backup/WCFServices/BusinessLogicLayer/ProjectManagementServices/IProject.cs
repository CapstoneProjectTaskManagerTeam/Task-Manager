using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.ProjectManagementServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProject" in both code and config file together.
    [ServiceContract]
    public interface IProject
    {
        [OperationContract]
        void DoWork();
    }
}
