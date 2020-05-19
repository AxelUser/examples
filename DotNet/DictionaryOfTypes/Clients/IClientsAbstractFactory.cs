namespace DictionaryOfTypes.Clients
{
    public interface IClientsAbstractFactory
    {
        IClientFactory<T> AllowedFactoryOf<T>() where T : class;
    }
}