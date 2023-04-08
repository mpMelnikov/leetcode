public class Solution881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        int left = 0;
        int right = people.Length - 1;
        int boatCount = 0;
        while(left <= right)
        {
            if(left != right)
            {
                if (people[left] + people[right] <= limit)
                {
                    left++;
                }
            }

            right--;
            boatCount++;
        }

        return boatCount;
    }
}
