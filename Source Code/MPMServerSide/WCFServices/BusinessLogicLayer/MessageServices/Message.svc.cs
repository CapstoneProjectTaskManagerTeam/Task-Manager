using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.Message
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Message" in code, svc and config file together.
    public class Message : IMessage
    {
        public int SendMessage(int sender, int receiver, string message)
        {
            throw new NotImplementedException();
        }
    }
}
