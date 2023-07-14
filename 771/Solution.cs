namespace _771;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;

        foreach (char s in stones)
        {
            foreach (char j in jewels)
            {
                if (s == j)
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}