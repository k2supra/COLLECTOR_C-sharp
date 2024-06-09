using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    static class Extension
    {
        public static bool isFibonacci(this int number)
        {
            if (number < 0) return false;

            bool IsPerfectSquare(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }
        public static int wordCounter(this string text)
        {
            var words = text.Split(new char[] {' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count();
        }
        public static int lastWordLettersCounter(this string text)
        {
            var words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words[words.Length - 1].Trim('.').Length;
        }
        public static bool checkBrackets(this string text)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                {'{', '}' },
                {'[', ']' },
                {'(', ')' },
            };
            foreach (char c in text)
            {
                if (brackets.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (brackets.ContainsValue(c))
                {
                    if (stack.Count == 0 || brackets[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        public static int[] Filter(this int[] ints, Predicate<int> filterPredicate)
        {
            List<int> result = new List<int>();
            foreach (var item in ints)
            {
                if (filterPredicate(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }

    internal class Program
    {
        public static bool isEven(int number) { return number % 2 == 0; }
        public static bool isOdd(int number) { return number % 2 == 1; }
        public static void Temperature(int[] temperatures)
        {
            int max = temperatures.Max();
            int min = temperatures.Min();
            int diff = max - min;
            Console.WriteLine($"Max temperature is {max}");
            Console.WriteLine($"Min temperature is {min}");
            Console.WriteLine($"Difference between max & min temperature is {diff}");
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21, 22 };
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} is a fibonacci number: {item.isFibonacci()}");
            }
            Console.WriteLine();
            string text = "Hello world. Welcome to the Los Polas Hermanos family.";
            Console.WriteLine($"Words in text: {text.wordCounter()}");
            Console.WriteLine($"Letters in the last word in text: {text.lastWordLettersCounter()}");
            Console.WriteLine();
            string[] testStrings = {
                "{}[]",
                "(())",
                "[{}]",
                "{[}]",
                "[[{]}]"
            };

            foreach (var test in testStrings)
            {
                Console.WriteLine($"String: \"{test}\" -> IsValid: {test.checkBrackets()}");
            }
            Console.WriteLine();
            int[] even = numbers.Filter(isEven);
            int[] odd = numbers.Filter(isOdd);
            Console.WriteLine("Even numbers: " + string.Join(", ", even));
            Console.WriteLine("Odd numbers: " + string.Join(", ", odd));
            Console.WriteLine();

            int[] temperatures = { -2, 0, 3, -1, 4, 3, 4, 0, 1 };
            Temperature(temperatures);
        }
    }
}
