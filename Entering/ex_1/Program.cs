using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 100: ");
            byte number = Convert.ToByte(Console.ReadLine());
            if (number <= 0 || number > 100)
            {
                Console.WriteLine("Error");
            }
            if (number % 3 == 0 && number % 5 != 0) 
            {
                Console.WriteLine("Fizz"); 
            }
            else if (number % 3 != 0 && number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
