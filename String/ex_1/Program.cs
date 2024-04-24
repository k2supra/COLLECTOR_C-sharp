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
            Console.Write("Enter 1 and 2 side sizes: ");
            int a_size = Convert.ToInt32(Console.ReadLine());
            int b_size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            displayQuare(a_size, b_size, symbol);
        }
        static void displayQuare(int a_size, int b_size, char symbol)
        {
            char[,] char_array = new char[a_size, b_size];
            for (int i = 0; i < a_size; i++)
            {
                for (int j = 0; j < b_size; j++)
                {
                    char_array[i, j] = symbol;
                    Console.Write(char_array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
