namespace RansomNote;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var groupNote = ransomNote.GroupBy(x => x)
                                  .ToDictionary(g => g.Key, g => g.Count());

        var groupMagazine = magazine.GroupBy(x => x)
                                    .ToDictionary(g => g.Key, g => g.Count());

        return groupNote.All(x => groupMagazine.ContainsKey(x.Key)
                                  && groupMagazine[x.Key] >= x.Value);
    }
}
