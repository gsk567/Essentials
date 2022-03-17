using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Essentials.Extensions;

namespace Essentials.Functions
{
    /// <summary>
    /// Essential type functions.
    /// </summary>
    public static class TypeFunctions
    {
        /// <summary>
        /// Returns a collection of all types that implements the specified interface from collection of assemblies.
        /// </summary>
        /// <param name="assemblies"></param>
        /// <typeparam name="TInterface">Type of the interface.</typeparam>
        /// <returns></returns>
        public static IEnumerable<Type> GetClassesTypesThatImplements<TInterface>(IEnumerable<Assembly> assemblies) =>
            GetClassesTypesThatImplementsAnInterface(typeof(TInterface), assemblies);

        /// <summary>
        /// Returns a collection of all types that implements the specified interface from collection of assemblies.
        /// </summary>
        /// <param name="interfaceType"></param>
        /// <param name="assemblies"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetClassesTypesThatImplementsAnInterface(
            Type interfaceType,
            IEnumerable<Assembly> assemblies)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("Specified type is not an interface", nameof(interfaceType));
            }

            return assemblies
                .SelectMany(x => x.GetTypes())
                .Where(x => x.IsClass && x.HasInterface(interfaceType))
                .ToList();
        }
    }
}