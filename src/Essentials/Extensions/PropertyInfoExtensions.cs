using System.Linq;
using System.Reflection;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="PropertyInfo"/>.
    /// </summary>
    public static class PropertyInfoExtensions
    {
        /// <summary>
        /// Check whether property info has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this PropertyInfo propertyInfo) =>
            propertyInfo.GetCustomAttributes(typeof(T), true).Any();

        /// <summary>
        /// Gets the specified attribute from property info.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.HasAttribute<T>())
            {
                return (T)propertyInfo.GetCustomAttributes(typeof(T), true).FirstOrDefault();
            }

            return default;
        }
    }
}