namespace _1281;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        return ProductOfDigits(n) - SumOfDigits(n);
    }

    private int ProductOfDigits(int n)
    {
        if (n < 10) return n;
        return (n % 10) * ProductOfDigits(n / 10);
    }

    private int SumOfDigits(int n)
    {
        if (n < 10) return n;
        return (n % 10) + SumOfDigits(n / 10);
    }
}
