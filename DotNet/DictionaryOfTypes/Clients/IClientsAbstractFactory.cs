namespace DictionaryOfTypes.Clients
{
    public interface IClientsAbstractFactory
    {
        IClientFactory<T> GetClientFactory<T>() where T : class;
    }
}