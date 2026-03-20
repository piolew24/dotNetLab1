namespace Lab1;

internal class Program
{
    private static void Main()
    {
        Problem problem = new(10, 3);
        var items = problem.GenerateItems();

        Console.WriteLine("Generated items:");
        foreach (var item in items) Console.WriteLine(item);

        var solution = problem.Solve(items, 20);
        Console.WriteLine("Selected items:");

        foreach (var item in solution) Console.WriteLine(item);
    }
}