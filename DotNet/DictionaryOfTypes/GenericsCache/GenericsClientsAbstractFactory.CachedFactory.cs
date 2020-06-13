using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.GenericsCache
{
    public partial class GenericsClientsAbstractFactory
    {
        private class CachedFactory<T> where T : class
        { 
            static CachedFactory()
            {
            }

            public static readonly IClientFactory<T>? Instance = CreateFactoryIfAllowed();
            
            private static IClientFactory<T>? CreateFactoryIfAllowed() =>
                DiscoveredAllowedClientTypes.TryGetValue(typeof(T), out var implType)
                    ? new ClientFactory<T>(implType)
                    : null;
        }
        
    }
}