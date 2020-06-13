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
                () => abstractFactory.AllowedFactoryOf<IResource0Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource1Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource2Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource3Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource4Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource5Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource6Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource7Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource8Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource9Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource10Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource11Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource12Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource13Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource14Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource15Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource16Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource17Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource18Client>(),
                () => abstractFactory.AllowedFactoryOf<IResource19Client>(),
            };
        }
    }
}
