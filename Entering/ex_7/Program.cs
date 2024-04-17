using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers: ");
            byte num1 = Convert.ToByte(Console.ReadLine());
            byte num2 = Convert.ToByte(Console.ReadLine());

            if (num1 > num2) 
            {
                byte temp = num2;
                num2 = num1;
                num1 = temp;
            }
            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i + " "); }
            }
        }
    }
}
