``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18362.836 (1903/May2019Update/19H1)
Intel Core i7-8700 CPU 3.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|                                  Method | Accesses |           Mean |         Error |        StdDev | Ratio |      Gen 0 | Gen 1 | Gen 2 |   Allocated |
|---------------------------------------- |--------- |---------------:|--------------:|--------------:|------:|-----------:|------:|------:|------------:|
|          **SimpleFactory_SequentialAccess** |      **100** |       **3.569 μs** |     **0.0122 μs** |     **0.0108 μs** |  **1.00** |     **0.3815** |     **-** |     **-** |      **2400 B** |
|          CachedFactory_SequentialAccess |      100 |       3.177 μs |     0.0214 μs |     0.0190 μs |  0.89 |          - |     - |     - |           - |
| CompiledGenericFactory_SequentialAccess |      100 |       1.375 μs |     0.0015 μs |     0.0013 μs |  0.39 |          - |     - |     - |           - |
|                                         |          |                |               |               |       |            |       |       |             |
|          **SimpleFactory_SequentialAccess** |     **1000** |      **35.872 μs** |     **0.2581 μs** |     **0.2288 μs** |  **1.00** |     **3.7842** |     **-** |     **-** |     **24000 B** |
|          CachedFactory_SequentialAccess |     1000 |      31.518 μs |     0.2336 μs |     0.2185 μs |  0.88 |          - |     - |     - |           - |
| CompiledGenericFactory_SequentialAccess |     1000 |      13.658 μs |     0.0283 μs |     0.0251 μs |  0.38 |          - |     - |     - |           - |
|                                         |          |                |               |               |       |            |       |       |             |
|          **SimpleFactory_SequentialAccess** | **10000000** | **360,600.713 μs** | **2,037.5719 μs** | **1,905.9460 μs** |  **1.00** | **38000.0000** |     **-** |     **-** | **240000000 B** |
|          CachedFactory_SequentialAccess | 10000000 | 305,781.587 μs | 2,950.7599 μs | 2,760.1426 μs |  0.85 |          - |     - |     - |           - |
| CompiledGenericFactory_SequentialAccess | 10000000 | 136,261.988 μs |   127.8780 μs |   106.7839 μs |  0.38 |          - |     - |     - |       334 B |
