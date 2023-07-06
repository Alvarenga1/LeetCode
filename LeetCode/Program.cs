namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new _1389.Solution();

            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };


            var result = solution.CreateTargetArray(nums,index);

            Console.WriteLine(result);
        }
    }
}