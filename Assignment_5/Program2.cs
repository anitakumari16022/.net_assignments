using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    class MultipleCatchExample
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input must be a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number is too large or too small for an Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }

}
