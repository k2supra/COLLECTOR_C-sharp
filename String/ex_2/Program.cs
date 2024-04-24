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
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            isPalindrom(number);
        }
        static void isPalindrom(int number)
        {
            int temp = number, reminder, sum = 0;
            while (number > 0) 
            {
                reminder = number % 10;
                sum = (sum * 10) + reminder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}
