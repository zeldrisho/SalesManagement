using System.Text;
using System.Security.Cryptography;

namespace BusinessLogic
{
    public static class AuthenticationUtil
    {
        /// <summary>
        /// Mã hóa mật khẩu
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string EncrytPassword(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }
    }
}
