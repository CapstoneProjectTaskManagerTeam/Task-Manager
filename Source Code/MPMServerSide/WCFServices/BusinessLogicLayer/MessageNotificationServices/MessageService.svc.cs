using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.MessageNotificationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageService" in code, svc and config file together.
    public class MessageService : IMessageService
    {
        public int SendMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public int AddNewMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessagebyUser(int userId)
        {
            throw new NotImplementedException();
        }

        public int DeleteMessage(int messageId)
        {
            throw new NotImplementedException();
        }
    }
}
