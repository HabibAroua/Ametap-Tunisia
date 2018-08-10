using System;
using System.Text;
using System.Security.Cryptography;

namespace AMETAP.View.Script
{
    public class Cryptage
    {
        public Cryptage()
        { }

        public String Encrypt(String value)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(value);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("f0xle@rn"));
                using 
				(
				    TripleDESCryptoServiceProvider tripeDes = new TripleDESCryptoServiceProvider()
                    { 
					    Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 
					}
				)
                {
                    ICryptoTransform transform = tripeDes.CreateEncryptor();
                    byte[] resulta = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(resulta, 0, resulta.Length);
                }
            }
        }

        public String Descrypt(String v)
        {
            String res = "";
            byte[] data = Convert.FromBase64String(v);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("f0xle@rn"));
                using (TripleDESCryptoServiceProvider tripeDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripeDes.CreateDecryptor();
                    byte[] resulta = transform.TransformFinalBlock(data, 0, data.Length);
                    res = UTF8Encoding.UTF8.GetString(resulta);
                    return res;
                }
            }
        }
    }

}
