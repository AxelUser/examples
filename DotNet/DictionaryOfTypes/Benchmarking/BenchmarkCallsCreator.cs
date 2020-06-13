using System;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.Benchmarking
{
    public static class BenchmarkCallsCreator
    {
        public static Action[] CreateInvocations(IClientsFactoryProvider factoryProvider)
        {
            return new Action[]
            {
                () => factoryProvider.GetClientFactory<IResource0Client>(),
                () => factoryProvider.GetClientFactory<IResource1Client>(),
                () => factoryProvider.GetClientFactory<IResource2Client>(),
                () => factoryProvider.GetClientFactory<IResource3Client>(),
                () => factoryProvider.GetClientFactory<IResource4Client>(),
                () => factoryProvider.GetClientFactory<IResource5Client>(),
                () => factoryProvider.GetClientFactory<IResource6Client>(),
                () => factoryProvider.GetClientFactory<IResource7Client>(),
                () => factoryProvider.GetClientFactory<IResource8Client>(),
                () => factoryProvider.GetClientFactory<IResource9Client>(),
                () => factoryProvider.GetClientFactory<IResource10Client>(),
                () => factoryProvider.GetClientFactory<IResource11Client>(),
                () => factoryProvider.GetClientFactory<IResource12Client>(),
                () => factoryProvider.GetClientFactory<IResource13Client>(),
                () => factoryProvider.GetClientFactory<IResource14Client>(),
                () => factoryProvider.GetClientFactory<IResource15Client>(),
                () => factoryProvider.GetClientFactory<IResource16Client>(),
                () => factoryProvider.GetClientFactory<IResource17Client>(),
                () => factoryProvider.GetClientFactory<IResource18Client>(),
                () => factoryProvider.GetClientFactory<IResource19Client>(),
            };
        }
    }
}
