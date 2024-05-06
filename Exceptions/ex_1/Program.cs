using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a convertion\n1 - to binary | 2 - to decades\n");
            byte ch = byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        toBinary();
                    }break;
                case 2:
                    {
                        toDecimal();
                    }
                    break;
                default:
                    break;
            }
        }
        static void toBinary()
        {
            Console.WriteLine("Enter a number");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Binary {number} = {Convert.ToString(number, 2)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{fe.Message}");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine($"{oe.Message}");
            }
        }
        static void toDecimal()
        {
            Console.WriteLine("Enter a number");
            try
            {
                string binary = Console.ReadLine();
                int decimal_n = Convert.ToInt32(binary, 2);
                Console.WriteLine($"Decimal {binary} = {decimal_n}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{fe.Message}");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine($"{oe.Message}");
            }
        }
    }
}
