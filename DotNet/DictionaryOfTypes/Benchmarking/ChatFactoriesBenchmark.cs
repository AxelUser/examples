using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DictionaryOfTypes.DictionaryCache;
using DictionaryOfTypes.GenericsCache;
using DictionaryOfTypes.Simple;

namespace DictionaryOfTypes.Benchmarking
{
    [MemoryDiagnoser]
    public class ChatFactoriesBenchmark
    {
        private Action[] _simpleFactoryRunActions = null!;
        private Action[] _compiledGenericsFactoryRunActions = null!;
        private Action[] _cachedFactoryRunActions = null!;

        [Params(100, 1000, 10000000)]
        public int Accesses { get; set; }

        [GlobalSetup]
        public void SetUp()
        {
            _simpleFactoryRunActions = BenchmarkCallsCreator.CreateInvocations(new SimpleClientFactory());
            _cachedFactoryRunActions = BenchmarkCallsCreator.CreateInvocations(new CachedSimpleAbstractFactory());
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