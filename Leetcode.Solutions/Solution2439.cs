public class Solution2439
{
    public int MinimizeArrayValue(int[] nums)
    {
        long sum = 0;
        int minMax = int.MinValue;
        for (int i = 0; i < nums.Length; ++i)
        {
            int num = nums[i];
            sum += num;

            long currentMinMax = (sum + i) / (i + 1);

            minMax = (int)Math.Max(minMax, currentMinMax);
        }

        return minMax;
    }
}
