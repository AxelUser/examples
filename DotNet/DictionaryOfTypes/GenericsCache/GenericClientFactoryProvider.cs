using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.GenericsCache
{
    public partial class GenericClientFactoryProvider : IClientsFactoryProvider
    {
        private static readonly Dictionary<Type, Type> DiscoveredAllowedClientTypes;

        public IClientFactory<T> GetClientFactory<T>() where T : class
        {
            return CachedFactory<T>.Instance ?? throw new Exception($"Client type '{typeof(T)}' isn't supported");
        }
        
        static GenericClientFactoryProvider()
        {
            DiscoveredAllowedClientTypes = ClientTypesProvider.GetAllTypes(Assembly.GetExecutingAssembly())
                .ToDictionary(tuple => tuple.@interface, tuple => tuple.implementation);

            var factory = typeof(CachedFactory<>);
            
            foreach (var @interface in DiscoveredAllowedClientTypes.Keys)
            {

                var genericFactory = factory.MakeGenericType(@interface);
                var instanceProperty = genericFactory.GetField("Instance");
                instanceProperty!.GetValue(null);
            }
        }
    }
}