using BenchmarkDotNet.Attributes;

namespace RichestCustomerWealth.Benchmarks;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly RichestCustomer _richestCustomer = new();
    private int[][] _items = new int[3][]
    {
        new int[3] { 2, 8, 7 },
        new int[3] { 7, 1, 3 },
        new int[3] { 1, 9, 5 }
    };

    [Benchmark]
    public int MaxLoop() => _richestCustomer.MaximumWealth(_items);
    
    [Benchmark]
    public int MaxLinq() => _richestCustomer.MaximumWealthLinq(_items);
}
