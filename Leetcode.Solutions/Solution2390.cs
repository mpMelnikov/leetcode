using System.Text;

public class Solution2390
{
    public string RemoveStars(string s)
    {
        var sb = new StringBuilder();

        foreach(char ch in s)
        {
            if (ch == '*' && sb.Length > 0)
            {
                sb.Length--;
            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}
