using System.Linq;
using System.Reflection;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="FieldInfo"/>.
    /// </summary>
    public static class FieldInfoExtensions
    {
        /// <summary>
        /// Check whether field info has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="fieldInfo"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this FieldInfo fieldInfo, bool inherit = true) =>
            fieldInfo.GetCustomAttributes(typeof(T), inherit).Any();

        /// <summary>
        /// Gets the specified attribute from field info.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="fieldInfo"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this FieldInfo fieldInfo, bool inherit = true)
        {
            if (fieldInfo.HasAttribute<T>())
            {
                return (T)fieldInfo.GetCustomAttributes(typeof(T), inherit).FirstOrDefault();
            }

            return default;
        }
    }
}