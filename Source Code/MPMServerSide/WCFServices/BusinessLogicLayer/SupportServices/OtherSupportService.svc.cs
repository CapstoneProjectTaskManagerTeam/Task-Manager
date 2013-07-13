using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Cryptography;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OtherSupport" in code, svc and config file together.
    public class OtherSupportService : IOtherSupportService
    {
        #region Encrypt and Decrypt String
        public string EncryptString(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.Default.GetBytes(str));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public string DecryptString(string str)
        {
            throw new NotImplementedException();
        }
        #endregion


        public string GetGravatar(string email, int size)
        {
            string hash = EncryptString(email);
            string url = string.Format("http://www.gravatar.com/avatar/{0}?size={1}", hash, size);
            return url;
        }

    }
}
