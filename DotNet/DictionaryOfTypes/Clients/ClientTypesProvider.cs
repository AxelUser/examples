using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DictionaryOfTypes.Clients
{
    public static class ClientTypesProvider
    {
        public static IEnumerable<(Type @interface, Type implementation)> GetAllTypes(Assembly assembly)
        {
            var clientsTypes = assembly.DefinedTypes
                .Where(type => type.CustomAttributes
                    .Any(attr => attr.AttributeType == typeof(RestClientAttribute)));
            
            foreach (var clientType in clientsTypes)
            {
                var @interface = clientType.ImplementedInterfaces.First();
                yield return (@interface, clientType);
            }
        }
    }
}