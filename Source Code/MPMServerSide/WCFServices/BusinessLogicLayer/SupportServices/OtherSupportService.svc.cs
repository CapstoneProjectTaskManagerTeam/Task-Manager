using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Security.Cryptography;
using System.Drawing;

namespace WCFServices.BusinessLogicLayer.SupportServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OtherSupport" in code, svc and config file together.
    public class OtherSupportService : IOtherSupportService
    {
        #region String Operations
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

        public string GenerateShortContent(string content)
        {
            // TODO : Get first words of content, sum of lengths of these word is less than 25
            throw new NotImplementedException();
        }
        #endregion

        #region Avatar Operations
        public string GetGravatar(string email, int size)
        {
            string hash = EncryptString(email);
            string url = string.Format("http://www.gravatar.com/avatar/{0}?size={1}", hash, size);
            return url;
        }

        public Image GetImage(string url)
        {
            throw new NotImplementedException();
        }

        public Image ResizeImage(Image img, int size)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Information Validation
        public int CheckName(string name)
        {
            throw new NotImplementedException();
        }

        public int CheckEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int CheckPassword(string password)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
