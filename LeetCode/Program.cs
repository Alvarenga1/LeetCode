namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        var solution = new _1603.ParkingSystem(1, 1, 0);

        var result = solution.AddCar(1);
        solution.AddCar(2);
        solution.AddCar(3);
        solution.AddCar(1);

        Console.WriteLine(result);
    }
}