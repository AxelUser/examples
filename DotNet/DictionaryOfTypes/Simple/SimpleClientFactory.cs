using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.Simple
{
    public class SimpleClientFactory: IClientsAbstractFactory
    {
        private static readonly Dictionary<Type, Type> DiscoveredAllowedClientTypes;
        
        static SimpleClientFactory()
        {
            DiscoveredAllowedClientTypes = ClientTypesProvider.GetAllTypes(Assembly.GetExecutingAssembly())
                .ToDictionary(tuple => tuple.@interface, tuple => tuple.implementation);
        }

        public IClientFactory<T> GetClientFactory<T>() where T : class
        {
            if(!DiscoveredAllowedClientTypes.TryGetValue(typeof(T), out var implType))
                throw new Exception($"Client type '{typeof(T)}' isn't supported");

            return new ClientFactory<T>(implType);
        }
    }
}