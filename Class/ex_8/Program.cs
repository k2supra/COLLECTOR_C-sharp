using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ex_8
{
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    public class Array : ICalc, IOutput2, ICalc2
    {
        private int[] elements;
        public Array(int[] numbers) { this.elements = numbers; }
        public int Less(int valueToCompare) 
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < valueToCompare)
                {
                    counter++;
                }
            }
            return counter;
        }
        public int Greater(int valueToCompare)
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > valueToCompare)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void ShowEven() 
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(elements[i] + " ");
                }
            }
        }
        public void ShowOdd()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(elements[i] + " ");
                }
            }
        }
        public int CountDistinct()
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (elements[i] == elements[j])
                    {
                        break;
                    }
                    else if (j == elements.Length - 1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        public int EqualToValue(int value)
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == value)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 11, 11 };
            Array array = new Array(elements);
            Console.WriteLine($"Numbers that less than 5 are {array.Less(5)}, and more than 5 are {array.Greater(5)}");
            Console.WriteLine("Even elements");
            array.ShowEven();
            Console.WriteLine("\nOdd elements");
            array.ShowOdd();
            Console.WriteLine($"\nUnique elements: {array.CountDistinct()}");
            Console.WriteLine($"Elements that equals 6: {array.EqualToValue(6)}");
        }
    }
}
