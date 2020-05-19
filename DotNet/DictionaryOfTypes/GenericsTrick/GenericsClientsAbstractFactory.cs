using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.GenericsTrick
{
    public partial class GenericsClientsAbstractFactory : IClientsAbstractFactory
    {
        private static readonly Dictionary<Type, Type> DiscoveredAllowedClientTypes;

        public IClientFactory<T> AllowedFactoryOf<T>() where T : class
        {
            return CachedFactory<T>.Instance ?? throw new Exception($"Client type '{typeof(T)}' isn't supported");
        }
        
        static GenericsClientsAbstractFactory()
        {
            DiscoveredAllowedClientTypes = ClientTypesProvider.GetAllTypes(Assembly.GetExecutingAssembly())
                .ToDictionary(tuple => tuple.@interface, tuple => tuple.implementation);
        }
    }
}