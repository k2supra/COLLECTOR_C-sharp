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
            Console.Write("Enter a problem: ");
            string problem = Console.ReadLine();
            string[] string_collection = { ">=", "<=", "!=", "==", ">", "<"};
            byte counter = 0;
            string choice = "";

            foreach (string item in string_collection) 
            {
                if (problem.Contains(item))
                {
                    choice = item;
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (counter == string_collection.Length) { throw new FormatException("Wrong problem"); };
            string[] parts = problem.Split(new string[] { choice }, StringSplitOptions.RemoveEmptyEntries);
            int first = int.Parse(parts[0]);
            int second = int.Parse(parts[1]);

            switch (choice)
            {
                case ">=":
                    {
                        if (first >= second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                case "<=":
                    {
                        if (first <= second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                case "<":
                    {
                        if (first < second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                case ">":
                    {
                        if (first > second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                case "!=":
                    {
                        if (first != second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                case "==":
                    {
                        if (first == second)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
