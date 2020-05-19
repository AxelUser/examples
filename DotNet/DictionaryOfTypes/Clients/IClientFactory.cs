using System;

namespace DictionaryOfTypes.Clients
{
    public interface IClientFactory<out T> where T: class
    {
        T Create(Guid from);
    }
}