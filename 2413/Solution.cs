using System.Numerics;

namespace _2413;

public class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        return (int)(n * 2 / BigInteger.GreatestCommonDivisor(n, 2));
    }
}