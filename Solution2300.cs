public class Solution2300
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);

        int[] result = new int[spells.Length];
        for(int i = 0; i < spells.Length; ++i)
        {
           long spell = spells[i];

           int start = 0;
           int end = potions.Length;

           while(start < end)
           {
               int middle = start + (end - start) / 2;
               long mult = spell * (long)potions[middle];
               if (mult >= success)
               {
                   end = middle;
               }
               else
               {
                   start = middle + 1;
               }
           }

           result[i] = potions.Length - start;
           Console.WriteLine($"i = {i}; spell = {spell}; start = {start}; end = {end}");
        }

        return result;
    }
}
