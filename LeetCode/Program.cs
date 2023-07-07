namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        var solution = new _1662.Solution();

        string[] word1 = { "a", "cb" };
        string[] word2 = { "ab", "c" };

        var result = solution.ArrayStringsAreEqual(word1,word2);

        Console.WriteLine(result);
    }
}