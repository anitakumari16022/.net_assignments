using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
          int[] transactions = { 200, -150, 340, 500, -100 };
            for(int i=0;i< transactions.Length; i++)
            {
                sum += transactions[i];
            }
            Console.WriteLine(sum);
        }
    }
}
