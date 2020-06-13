``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18362.836 (1903/May2019Update/19H1)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|                                  Method | Accesses |           Mean |         Error |        StdDev | Ratio | RatioSD |      Gen 0 | Gen 1 | Gen 2 |   Allocated |
|---------------------------------------- |--------- |---------------:|--------------:|--------------:|------:|--------:|-----------:|------:|------:|------------:|
|          **SimpleFactory_SequentialAccess** |      **100** |       **3.656 μs** |     **0.0703 μs** |     **0.0810 μs** |  **1.00** |    **0.00** |     **0.3815** |     **-** |     **-** |      **2400 B** |
|          CachedFactory_SequentialAccess |      100 |       3.161 μs |     0.0160 μs |     0.0149 μs |  0.87 |    0.02 |          - |     - |     - |           - |
| CompiledGenericFactory_SequentialAccess |      100 |       1.369 μs |     0.0027 μs |     0.0025 μs |  0.38 |    0.01 |          - |     - |     - |           - |
|                                         |          |                |               |               |       |         |            |       |       |             |
|          **SimpleFactory_SequentialAccess** |     **1000** |      **36.652 μs** |     **0.7192 μs** |     **0.7695 μs** |  **1.00** |    **0.00** |     **3.7842** |     **-** |     **-** |     **24000 B** |
|          CachedFactory_SequentialAccess |     1000 |      31.170 μs |     0.1677 μs |     0.1569 μs |  0.85 |    0.02 |          - |     - |     - |           - |
| CompiledGenericFactory_SequentialAccess |     1000 |      13.572 μs |     0.0092 μs |     0.0086 μs |  0.37 |    0.01 |          - |     - |     - |           - |
|                                         |          |                |               |               |       |         |            |       |       |             |
|          **SimpleFactory_SequentialAccess** | **10000000** | **354,869.333 μs** |   **563.3256 μs** |   **439.8076 μs** |  **1.00** |    **0.00** | **38000.0000** |     **-** |     **-** | **240000000 B** |
|          CachedFactory_SequentialAccess | 10000000 | 306,629.347 μs | 2,434.7538 μs | 2,277.4702 μs |  0.86 |    0.01 |          - |     - |     - |      1808 B |
| CompiledGenericFactory_SequentialAccess | 10000000 | 135,815.296 μs |   190.7716 μs |   169.1140 μs |  0.38 |    0.00 |          - |     - |     - |       306 B |
