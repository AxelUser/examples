using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.CacheFactoriesInDictionary
{
    public class CachedSimpleFactory: IClientsAbstractFactory
    {
        private static readonly Type FactoryType = typeof(ClientFactory<>);
        private static readonly Dictionary<Type, object> CachedClientFactories;
        
        static CachedSimpleFactory()
        {
            CachedClientFactories = ClientTypesProvider.GetAllTypes(Assembly.GetExecutingAssembly())
                .ToDictionary(tuple => tuple.@interface, tuple => CreateFactory(tuple.implementation));
        }

        public IClientFactory<T> AllowedFactoryOf<T>() where T : class
        {
            if(!CachedClientFactories.TryGetValue(typeof(T), out var factory))
                throw new Exception($"Client type '{typeof(T)}' isn't supported");

            return (IClientFactory<T>) factory;
        }

        private static object CreateFactory(Type clientType)
        {
            var factory = FactoryType.MakeGenericType(clientType);
            return Activator.CreateInstance(factory, clientType)!;
        }
    }
}