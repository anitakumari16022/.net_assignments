using System;

class DivisionExample
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            double result = numerator / denominator;
            Console.WriteLine($"Result = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
