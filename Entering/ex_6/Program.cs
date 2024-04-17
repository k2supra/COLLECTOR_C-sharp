using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Convert to F - 1 | K - 2:");
            byte ch = Convert.ToByte(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine($"F {((temperature * 9) / 5) + 32}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"K {temperature + 273}");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
