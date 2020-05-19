using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DictionaryOfTypes.CacheFactoriesInDictionary;
using DictionaryOfTypes.GenericsTrick;
using DictionaryOfTypes.SimpleDictionary;

namespace DictionaryOfTypes.Benchmarking
{
    [DisassemblyDiagnoser]
    public class ChatFactoriesBenchmark
    {
        private Action[] _simpleFactoryRunActions;
        private Action[] _compiledGenericsFactoryRunActions;
        private Action[] _cachedFactoryRunActions;

        [Params(100, 1000, 100000)]
        public int Accesses { get; set; }

        [GlobalSetup]
        public void SetUp()
        {
            _simpleFactoryRunActions = BenchmarkCallsCreator.CreateInvocations(new SimpleClientFactory());
            _cachedFactoryRunActions = BenchmarkCallsCreator.CreateInvocations(new CachedSimpleFactory());
            _compiledGenericsFactoryRunActions = BenchmarkCallsCreator.CreateInvocations(new GenericsClientsAbstractFactory());
        }

        [Benchmark(Baseline = true)]
        public void SimpleFactory_SequentialAccess()
        {
            Execute(_simpleFactoryRunActions);
        }
        
        [Benchmark]
        public void CachedFactory_SequentialAccess()
        {
            Execute(_cachedFactoryRunActions);
        }
        
        [Benchmark]
        public void CompiledGenericFactory_SequentialAccess()
        {
            Execute(_compiledGenericsFactoryRunActions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Execute(IReadOnlyList<Action> actions)
        {
            var length = actions.Count;
            for (var i = 0; i < Accesses; i++)
            {
                actions[i % length]();
            }
        }
        
        public static void Run()
        {
            BenchmarkRunner.Run<ChatFactoriesBenchmark>();
        }
    }
}