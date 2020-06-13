using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.DictionaryCache
{
    public class CachedSimpleAbstractFactory: IClientsAbstractFactory
    {
        private static readonly Type FactoryType = typeof(ClientFactory<>);
        private static readonly Dictionary<Type, object> CachedClientFactories;
        
        static CachedSimpleAbstractFactory()
        {
            CachedClientFactories = ClientTypesProvider.GetAllTypes(Assembly.GetExecutingAssembly())
                .ToDictionary(tuple => tuple.@interface, tuple => CreateFactory(tuple.implementation));
        }

        public IClientFactory<T> GetClientFactory<T>() where T : class
        {
            if(!CachedClientFactories.TryGetValue(typeof(T), out var factory))
                throw new Exception($"Client type '{typeof(T)}' isn't supported");

            return Unsafe.As<IClientFactory<T>>(factory);
        }

        private static object CreateFactory(Type clientType)
        {
            var factory = FactoryType.MakeGenericType(clientType);
            return Activator.CreateInstance(factory, clientType)!;
        }
    }
}