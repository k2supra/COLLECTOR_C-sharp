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
            try
            {
                Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"zero", 0 },
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9}
            };
                Console.Write("Enter a number in string form: ");
                string number = Console.ReadLine().ToLower();
                if (!dict.ContainsKey(number))
                {
                    throw new ArgumentException("Wrong word/number");
                }
                Console.WriteLine($"Number = {dict[number]}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
