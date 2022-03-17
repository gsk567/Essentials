using System.Security.Cryptography;
using System.Text;

namespace Essentials.Functions
{
    /// <summary>
    /// Essentials cryptography functions.
    /// </summary>
    public static class CryptoFunctions
    {
        /// <summary>
        /// Generate MD5 hash from string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Hash(string input)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);
            var stringBuilder = new StringBuilder();
            foreach (var hashByte in hash)
            {
                stringBuilder.Append(hashByte.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}