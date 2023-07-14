namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        var solution = new _771.Solution();

        var result = solution.NumJewelsInStones("aA", "aAAbbbb");

        Console.WriteLine(result);
    }
}