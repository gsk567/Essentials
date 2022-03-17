using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Type"/>.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns the default value of type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object GetDefaultValue(this Type type)
        {
            var defaultExpression = Expression.Convert(Expression.Default(type), typeof(object));
            var expression = Expression.Lambda<Func<object>>(defaultExpression);
            return expression.Compile()();
        }

        /// <summary>
        /// Check whether the type has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="type"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this Type type, bool inherit = true) =>
            type.GetCustomAttributes(typeof(T), inherit).Any();

        /// <summary>
        /// Gets the specified attribute or default from type.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="type"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this Type type, bool inherit = true)
        {
            if (type.HasAttribute<T>())
            {
                return (T)type.GetCustomAttributes(typeof(T), inherit).FirstOrDefault();
            }

            return default;
        }

        /// <summary>
        /// Check whether the type implement the specified interface.
        /// </summary>
        /// <param name="type"></param>
        /// <typeparam name="T">Type of interface.</typeparam>
        /// <returns></returns>
        public static bool HasInterface<T>(this Type type) =>
            type.HasInterface(typeof(T));

        /// <summary>
        /// Check whether the type implement the specified interface.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="interfaceType"></param>
        /// <returns></returns>
        public static bool HasInterface(this Type type, Type interfaceType) =>
            type.GetInterfaces().Any(x => x == interfaceType);

        /// <summary>
        /// Gets type by ignoring the nullable type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetTypeByIgnoreTheNullable(this Type type)
        {
            try
            {
                return Nullable.GetUnderlyingType(type) != null ? Nullable.GetUnderlyingType(type) : type;
            }
            catch (Exception)
            {
                return type;
            }
        }

        /// <summary>
        /// Checks whether a type is a iterable type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIterableType(this Type type)
        {
            var originalSourceType = type.GetTypeByIgnoreTheNullable();
            var isEnumerableType = originalSourceType.IsEnumerableType();
            var isCollectionType = originalSourceType.IsCollectionType();
            var isArray = originalSourceType.IsArray;

            return isEnumerableType || isCollectionType || isArray;
        }

        /// <summary>
        /// Checks whether a type is a collection or not.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsCollectionType(this Type type) => type.ImplementsGenericInterface(typeof(ICollection<>));

        /// <summary>
        /// Checks whether a type is a list or not.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsListType(this Type type) => typeof(IList).IsAssignableFrom(type);

        /// <summary>
        /// Checks whether a type is enumerable.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsEnumerableType(this Type type) => typeof(IEnumerable).IsAssignableFrom(type);

        /// <summary>
        /// Check whether a type is implement a generic interface.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="interfaceType"></param>
        /// <returns></returns>
        public static bool ImplementsGenericInterface(this Type type, Type interfaceType) =>
            type.GetGenericInterface(interfaceType) != null;

        /// <summary>
        /// Checks whether a type is a generic type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="genericType"></param>
        /// <returns></returns>
        public static bool IsGenericType(this Type type, Type genericType) =>
            type.IsGenericType && type.GetGenericTypeDefinition() == genericType;

        /// <summary>
        /// Get generic interface of a type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="genericInterface"></param>
        /// <returns></returns>
        public static Type GetGenericInterface(this Type type, Type genericInterface) =>
            type.IsGenericType(genericInterface) ? type : type.GetInterfaces().FirstOrDefault(t => t.IsGenericType(genericInterface));
    }
}