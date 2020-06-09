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
                () => abstractFactory.AllowedFactoryOf<IChatRoom0Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom1Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom2Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom3Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom4Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom5Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom6Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom7Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom8Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom9Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom10Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom11Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom12Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom13Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom14Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom15Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom16Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom17Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom18Client>(),
                () => abstractFactory.AllowedFactoryOf<IChatRoom19Client>(),
            };
        }
    }
}
