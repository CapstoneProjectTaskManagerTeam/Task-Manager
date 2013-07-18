using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOtherSupport" in both code and config file together.
    [ServiceContract]
    public interface IOtherSupportService
    {
        #region String Operations
        [OperationContract]
        string EncryptString(string str);

        [OperationContract]
        string GenerateShortContent(string content);
        #endregion

        #region Avatar Operations
        [OperationContract]
        string GetGravatar(string email, int size);

        [OperationContract]
        Image GetImage(String url);

        [OperationContract]
        Image ResizeImage(Image img, int size);
        #endregion

        #region Information Validation
        [OperationContract]
        int CheckName(string name);

        [OperationContract]
        int CheckEmail(string email);

        [OperationContract]
        int CheckPassword(string password);
        #endregion

    }
}
