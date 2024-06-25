using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter the path of the file to reverse: ");
            string inputFilePath = Console.ReadLine();*/
            string inputFilePath = "test.txt";

            string[] lines = File.ReadAllLines(inputFilePath);
            string[] output = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                output[i] = ReverseLine(lines[i]);
            }
            File.WriteAllLines(inputFilePath, output);
            Console.WriteLine("File content reversed successfully.");
        }
        public static string ReverseLine(string line)
        {
            char[] chars = line.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
