using System.Globalization;

namespace QuadraticEquationSolver;

class Program
{
    static void Main(string[] args)
    {
        double a, b = 0, c = 0;

        if (args.Length == 0)
        {
            // Інтерактивний режим
            a = ReadCoefficient("a");
            b = ReadCoefficient("b");
            c = ReadCoefficient("c");
        }
        else if (args.Length == 1)
        {
            // Неінтерактивний (файловий) режим
            var path = args[0];

            if (!File.Exists(path))
            {
                Console.WriteLine($"file {path} does not exist");
                Environment.Exit(1);
            }

            try
            {
                var content = File.ReadAllText(path).Trim();
                var parts = content.Split([' '], StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 3)
                {
                    Console.WriteLine("invalid file format");
                    Environment.Exit(1);
                }

                if (!double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out a) ||
                    !double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out b) ||
                    !double.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out c))
                {
                    Console.WriteLine("invalid file format");
                    Environment.Exit(1);
                }
            }
            catch
            {
                Console.WriteLine("invalid file format");
                Environment.Exit(1);
                return;
            }
        }
        else
        {
            Console.WriteLine(args.Length);
            Console.WriteLine("Usage: equation");
            Environment.Exit(1);
            return;
        }

        if (Math.Abs(a) < 1e-10)
        {
            Console.WriteLine("Error. a cannot be 0");
            Environment.Exit(1);
            return;
        }

        SolveEquation(a, b, c);
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

    static void SolveEquation(double a, double b, double c)
    {
        Console.WriteLine($"Equation is: ({a}) x^2 + ({b}) x + ({c}) = 0");

        var discriminant = b * b - 4 * a * c;

        if (discriminant > 1e-10)
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
}