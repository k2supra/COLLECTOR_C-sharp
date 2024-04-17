using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a percent: ");
            double percent = Convert.ToDouble(Console.ReadLine());
            double result = (percent / 100) * number;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
