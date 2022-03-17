using System;
using System.Security.Cryptography;
using System.Text;

namespace Essentials.Functions
{
    /// <summary>
    /// Essentials random generation functions.
    /// </summary>
    public static class RandomFunctions
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Gets a random element from array.
        /// </summary>
        /// <typeparam name="T">Type of the array elements.</typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T GetRandomElementFromArray<T>(T[] array) =>
            array[Random.Next(0, array.Length)];

        /// <summary>
        /// Gets a random string.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="usedChars"></param>
        /// <returns></returns>
        public static string GetRandomString(
            int size,
            string usedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
        {
            var chars = usedChars.ToCharArray();
            var data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }

            var result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var random = BitConverter.ToUInt32(data, i * 4);
                var index = random % chars.Length;
                result.Append(chars[index]);
            }

            return result.ToString();
        }
    }
}