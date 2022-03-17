using System;
using System.Linq.Expressions;

namespace Essentials.Functions
{
    /// <summary>
    /// Essentials expression functions.
    /// </summary>
    public static class ExpressionFunctions
    {
        /// <summary>
        /// Build lambda expression from entity type and property name.
        /// Example BuildExpressionForProperty{Entity}("Id") represents (Entity x) => x.Id.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <returns></returns>
        public static Expression<Func<TEntity, object>> BuildExpressionForProperty<TEntity>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(TEntity));
            var property = Expression.Property(parameter, propertyName);
            var propertyAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<TEntity, object>>(propertyAsObject, parameter);
        }

        /// <summary>
        /// Creates an expressions with OR conditional operation.
        /// </summary>
        /// <typeparam name="T">Type of the entity for expression.</typeparam>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CombineByOrElseCondition<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            Expression<Func<T, bool>> combined = Expression.Lambda<Func<T, bool>>(
                Expression.OrElse(
                    left.Body,
                    new ExpressionParameterReplacer(right.Parameters, left.Parameters).Visit(right.Body)), left.Parameters);

            return combined;
        }

        /// <summary>
        /// Creates an expressions with AND conditional operation.
        /// </summary>
        /// <typeparam name="T">Type of the entity for expression.</typeparam>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CombineByAndAlsoCondition<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            Expression<Func<T, bool>> combined = Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(
                    left.Body,
                    new ExpressionParameterReplacer(right.Parameters, left.Parameters).Visit(right.Body)), left.Parameters);

            return combined;
        }
    }
}