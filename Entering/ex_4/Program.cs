using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("ERROR");
            }
            Console.WriteLine("Enter 2 positions: ");
            int pos1 = Convert.ToInt32(Console.ReadLine());
            int pos2 = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int[6];
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            int temp = digits[pos1-1];
            digits[pos1-1] = digits[pos2-1];
            digits[pos2-1] = temp;

            int result = 0;
            for (int i = 0; i < 6; i++)
            {
                result = result * 10 + digits[i];
            }

            Console.WriteLine($"Changed number is {result}");
        }
    }
}
