public class Solution516
{
    private int[,] _dp;

    public int LongestPalindromeSubseq(string s)
    {
        _dp = new int[s.Length, s.Length];
        
        return LongestPalindrome(s, 0, s.Length - 1);
    }

    private int LongestPalindrome(string s, int start, int end)
    {
        if (start == end) return 1;

        if (start > end) return 0;

        if (_dp[start, end] == 0)
        {
            int result = 0;

            if (s[start] == s[end])
            {
                result = 2 + LongestPalindrome(s, start + 1, end - 1);
            }
            else
            {
                result = Math.Max(
                        LongestPalindrome(s, start + 1, end),
                        LongestPalindrome(s, start, end - 1));
            }

            _dp[start, end] = result;
        }

        return _dp[start, end]; 
    }
}
