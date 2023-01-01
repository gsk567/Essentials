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
        /// <param name="algorithm"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HashString(string input, HashAlgorithm algorithm, Encoding encoding = null)
        {
            var targetEncoding = encoding ?? Encoding.UTF8;
            var inputBytes = targetEncoding.GetBytes(input);
            var hash = algorithm.ComputeHash(inputBytes);
            var stringBuilder = new StringBuilder();
            foreach (var hashByte in hash)
            {
                stringBuilder.Append(hashByte.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}