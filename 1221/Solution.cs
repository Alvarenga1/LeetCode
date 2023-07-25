namespace _1221;

public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int splitCount = 0;
        int rCount = 0;
        int lCount = 0;

        foreach (char c in s)
        {
            if (c == 'R')
            {
                rCount++;
            }
            else
            {
                lCount++;
            }
            if (rCount == lCount)
            {
                splitCount++;
                rCount = 0;
                lCount = 0;
            }
        }


        return splitCount;
    }
}