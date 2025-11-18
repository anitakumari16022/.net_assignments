using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomExceptionDemo
{

    public class NegativeSalaryException : Exception
    {
        public NegativeSalaryException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string [] args)
        {
            try
            {
                Console.Write("Enter your salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

               
                if (salary < 0)
                {
                    throw new NegativeSalaryException("Error: Salary cannot be negative!");
                }

                Console.WriteLine($"Your entered salary is: {salary}");
            }
            catch (NegativeSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
