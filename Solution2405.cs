public class Solution2405
{
    public int PartitionString(string s)
    {
        HashSet<char> group = new();
        int groupCount = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (group.Contains(s[i]))
            {
                group.Clear();
                groupCount++;
            }

            group.Add(s[i]);
        }

        if (group.Count > 0)
        {
            groupCount++;
        }

        return groupCount;
    }
}
