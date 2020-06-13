using System;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.Benchmarking
{
    public static class BenchmarkCallsCreator
    {
        public static Action[] CreateInvocations(IClientsAbstractFactory abstractFactory)
        {
            return new Action[]
            {
                () => abstractFactory.GetClientFactory<IResource0Client>(),
                () => abstractFactory.GetClientFactory<IResource1Client>(),
                () => abstractFactory.GetClientFactory<IResource2Client>(),
                () => abstractFactory.GetClientFactory<IResource3Client>(),
                () => abstractFactory.GetClientFactory<IResource4Client>(),
                () => abstractFactory.GetClientFactory<IResource5Client>(),
                () => abstractFactory.GetClientFactory<IResource6Client>(),
                () => abstractFactory.GetClientFactory<IResource7Client>(),
                () => abstractFactory.GetClientFactory<IResource8Client>(),
                () => abstractFactory.GetClientFactory<IResource9Client>(),
                () => abstractFactory.GetClientFactory<IResource10Client>(),
                () => abstractFactory.GetClientFactory<IResource11Client>(),
                () => abstractFactory.GetClientFactory<IResource12Client>(),
                () => abstractFactory.GetClientFactory<IResource13Client>(),
                () => abstractFactory.GetClientFactory<IResource14Client>(),
                () => abstractFactory.GetClientFactory<IResource15Client>(),
                () => abstractFactory.GetClientFactory<IResource16Client>(),
                () => abstractFactory.GetClientFactory<IResource17Client>(),
                () => abstractFactory.GetClientFactory<IResource18Client>(),
                () => abstractFactory.GetClientFactory<IResource19Client>(),
            };
        }
    }
}
