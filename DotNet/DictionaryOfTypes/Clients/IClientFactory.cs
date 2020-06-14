using System.Net.Http;

namespace DictionaryOfTypes.Clients
{
    public interface IClientFactory<out T> where T: class
    {
        T Create(HttpClient client);
    }
}