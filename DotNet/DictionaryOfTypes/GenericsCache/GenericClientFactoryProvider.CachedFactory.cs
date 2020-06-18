using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.GenericsCache
{
    public partial class GenericClientFactoryProvider
    {
        private class CachedFactory<T> where T : class
        {
            public static readonly IClientFactory<T>? Instance;
            
            static CachedFactory()
            {
                Instance = CreateFactoryIfAllowed();
            }

            private static IClientFactory<T>? CreateFactoryIfAllowed() =>
                DiscoveredAllowedClientTypes.TryGetValue(typeof(T), out var implType)
                    ? new ClientFactory<T>(implType)
                    : null;
        }
    }
}