namespace SoldierRows;

public class SoldierRows
{
    public int[] KWeakestRows(int[][] mat, int k) => 
        Enumerable.Range(0, mat.GetLength(0))
                  .Select(m => new { Row = m, Soldiers = mat[m].Count(i => i == 1) })
                  .OrderBy(r => r.Soldiers)
                  .ThenBy(r => r.Row)
                  .Select(r => r.Row)
                  .Take(k)
                  .ToArray();
}

