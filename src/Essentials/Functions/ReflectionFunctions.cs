using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Essentials.Functions
{
    /// <summary>
    /// Essential reflection functions.
    /// </summary>
    public static class ReflectionFunctions
    {
        /// <summary>
        /// Gets property member info.
        /// </summary>
        /// <param name="expression"></param>
        /// <typeparam name="TProperty">Type of the object.</typeparam>
        /// <returns></returns>
        public static MemberInfo GetCorrectPropertyMember<TProperty>(Expression<Func<TProperty, object>> expression)
        {
            return GetCorrectPropertyMember<TProperty, object>(expression);
        }

        /// <summary>
        /// Gets property member info.
        /// </summary>
        /// <param name="expression"></param>
        /// <typeparam name="TProperty">Type of the object.</typeparam>
        /// <typeparam name="TResult">Type of the property.</typeparam>
        /// <returns></returns>
        public static MemberInfo GetCorrectPropertyMember<TProperty, TResult>(Expression<Func<TProperty, TResult>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member;
            }

            var operand = ((UnaryExpression)expression.Body).Operand;
            return ((MemberExpression)operand).Member;
        }
    }
}