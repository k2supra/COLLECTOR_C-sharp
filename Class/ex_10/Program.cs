using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10
{
    struct DecimalNumber
    {
        public int Number { get; set; }
        public DecimalNumber(int value) { Number = value; }
        public string ToBinary()
        {
            return Convert.ToString(this.Number, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(this.Number, 8);
        }
        public string ToHexadecimal()
        {
            return Convert.ToString(this.Number, 16);
        }
        public override string ToString()
        {
            return this.Number.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DecimalNumber number = new DecimalNumber(5);
            string binary = number.ToBinary();
            string octal = number.ToOctal();
            string hexadecimal = number.ToHexadecimal();
            Console.WriteLine($"{number} to binary is {binary}");
            Console.WriteLine($"{number} to octal is {octal}");
            Console.WriteLine($"{number} to hexadecimal is {hexadecimal}");
        }
    }
}
