namespace DictionaryOfTypes.Clients
{
    public interface IClientsFactoryProvider
    {
        IClientFactory<T> GetClientFactory<T>() where T : class;
    }
}