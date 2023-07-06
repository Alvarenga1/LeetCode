namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new _1773.Solution();

            IList<IList<string>> items = new List<IList<string>>
        {
            new List<string> {"phone","blue","pixel"},
            new List<string> {"computer","silver","lenovo"},
            new List<string> { "phone", "gold", "iphone" }
        };

            var result = solution.CountMatches(items, "color", "silver");

            Console.WriteLine(result);
        }
    }
}