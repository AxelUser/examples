using System;

namespace DictionaryOfTypes.Clients
{
    public class ClientFactory<T>: IClientFactory<T> where T : class
    {
        private readonly Type _clientImplType;

        public ClientFactory(Type clientImplType)
        {
            _clientImplType = clientImplType;
        }
        
        public T Create(Guid from)
        {
            return (T) Activator.CreateInstance(_clientImplType, from)!;
        }
    }
}