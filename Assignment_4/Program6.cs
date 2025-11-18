using System;

delegate void Operation(double a, double b);

class Arithmetic
{
    static void Add(double x, double y)
    {
        Console.WriteLine($"Addition: {x + y}");
    }

    static void Subtract(double x, double y)
    {
        Console.WriteLine($"Subtraction: {x - y}");
    }

    static void Main()
    {
        Operation op = Add;
        op += Subtract;

        Console.Write("Enter first number: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        op(n1, n2);
    }
}
