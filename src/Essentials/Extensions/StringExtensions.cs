using System.Linq;
using Pluralize.NET;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        private static readonly IPluralize Pluralizer = new Pluralizer();

        /// <summary>
        /// Gets plural form of string.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToPluralString(this string stringValue)
        {
            return Pluralizer.Pluralize(stringValue);
        }

        /// <summary>
        /// Gets singular form of a string.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToSingularString(this string stringValue)
        {
            return Pluralizer.Singularize(stringValue);
        }

        /// <summary>
        /// Transforms the first char of string in uppercase.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToFirstUpper(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return stringValue;
            }

            return stringValue.First().ToString().ToUpper() + (stringValue.Length > 1 ? stringValue.Substring(1) : string.Empty);
        }

        /// <summary>
        /// Transforms the first char of string in lowercase.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToFirstLower(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return stringValue;
            }

            return stringValue.First().ToString().ToLower() + (stringValue.Length > 1 ? stringValue.Substring(1) : string.Empty);
        }
    }
}