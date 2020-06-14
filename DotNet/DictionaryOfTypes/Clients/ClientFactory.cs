using System;
using System.Net.Http;

namespace DictionaryOfTypes.Clients
{
    public class ClientFactory<T>: IClientFactory<T> where T : class
    {
        private readonly Type _clientImplType;

        public ClientFactory(Type clientImplType)
        {
            _clientImplType = clientImplType;
        }
        
        public T Create(HttpClient client)
        {
            return (T) Activator.CreateInstance(_clientImplType, client)!;
        }
    }
}