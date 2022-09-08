using BenchmarkDotNet.Attributes;

namespace SoldierRows.Benchmarks;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly SoldierRows _solderiRows = new();
    
    private int[][] _items = new int[5][]
    {
        new[] { 1, 1, 0, 0, 0 },
        new[] { 1, 1, 1, 1, 0 },
        new[] { 1, 0, 0, 0, 0 },
        new[] { 1, 1, 0, 0, 0 },
        new[] { 1, 1, 1, 1, 1 }
    };

    [Benchmark]
    public int[] KWeakestRowsLinq() => _solderiRows.KWeakestRows(_items, 3);
}
