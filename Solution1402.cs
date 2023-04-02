public class Solution1402
{
    private int?[,] _dp;
    // dp[position, time]

    public int MaxSatisfaction(int[] satisfaction)
    {
        Array.Sort(satisfaction);

        _dp = new int?[satisfaction.Length + 1, satisfaction.Length + 1];

        return MaxSatisfaction(satisfaction, 0, 1);
    }

    private int MaxSatisfaction(int[] satisfaction, int index, int step)
    {
        if (index == satisfaction.Length) return 0;

        if (_dp[index, step] == null)
        {
            _dp[index, step] = Math.Max(
                satisfaction[index] * step + MaxSatisfaction(satisfaction, index + 1, step + 1),
                MaxSatisfaction(satisfaction, index + 1, 1));
        }

        return _dp[index, step].Value;
    }
}
