using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Toci.SeeSharpBasics.Test.Common
{
    public class AssemblyLoader
    {
        public IEnumerable<Type> GetTypesList<T>()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            List<Type> expectedTypes = new List<Type>();

            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();

                expectedTypes.AddRange(types.Where(t => typeof(T).IsAssignableFrom(t) && t.IsSubclassOf(typeof(T))));
            }

            return expectedTypes;
        }

        public IEnumerable<T> GetTypesInstancesList<T>()
        {
            var types = GetTypesList<T>();

            return types.Select(type => (T) Activator.CreateInstance(type)).ToList();
        }
    }
}