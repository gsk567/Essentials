using System.Linq;
using System.Reflection;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="MethodInfo"/>.
    /// </summary>
    public static class MethodInfoExtensions
    {
        /// <summary>
        /// Check whether method info has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="methodInfo"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this MethodInfo methodInfo, bool inherit = true) =>
            methodInfo.GetCustomAttributes(typeof(T), inherit).Any();

        /// <summary>
        /// Gets the specified attribute from method info.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="methodInfo"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this MethodInfo methodInfo, bool inherit = true)
        {
            if (methodInfo.HasAttribute<T>())
            {
                return (T)methodInfo.GetCustomAttributes(typeof(T), inherit).FirstOrDefault();
            }

            return default;
        }
    }
}