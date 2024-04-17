using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 nunbers:");
            int number1 = Convert.ToInt16(Console.ReadLine());
            int number2 = Convert.ToInt16(Console.ReadLine());
            int number3 = Convert.ToInt16(Console.ReadLine());
            int number4 = Convert.ToInt16(Console.ReadLine());

            int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;
            Console.WriteLine($"Result: {result}");
        }
    }
}
