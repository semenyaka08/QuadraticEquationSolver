using System.Globalization;

namespace QuadraticEquationSolver;

class Program
{
    static void Main(string[] args)
    {
        var a = ReadCoefficient("a");
        var b = ReadCoefficient("b");
        var c = ReadCoefficient("c");

        Console.WriteLine($"Equation is: ({a}) x^2 + ({b}) x + ({c}) = 0");

        var discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            var x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("There are 2 roots");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (Math.Abs(discriminant) < 1e-10)
        {
            var x = -b / (2 * a);
            Console.WriteLine("There is 1 root");
            Console.WriteLine($"x1 = {x}");
        }
        else
        {
            Console.WriteLine("There are 0 roots");
        }
    }
    
    static double ReadCoefficient(string name)
    {
        while (true)
        {
            Console.Write($"{name} = ");
            var input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
            {
                return value;
            }

            Console.WriteLine($"Error. Expected a valid real number, got {input} instead");
        }
    }
}