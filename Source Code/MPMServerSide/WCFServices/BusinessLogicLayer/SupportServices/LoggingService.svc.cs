﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Logging" in code, svc and config file together.
    public class LoggingService : ILoggingService
    {
        public void SendLog(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
