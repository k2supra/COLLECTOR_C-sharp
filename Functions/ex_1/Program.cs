using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    public delegate int[] ArrayDelegate();
    class Array
    {
        private int[] array;
        public Array(int[] arr) { this.array = arr; }

        public int[] GetOdd()
        {
            List<int> res = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (this.array[i] % 2 == 1)
                {
                    res.Add(this.array[i]);
                }
            }
            return res.ToArray();
        }
        public int[] GetEven()
        {
            List<int> res = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (this.array[i] % 2 == 0)
                {
                    res.Add(this.array[i]);
                }
            }
            return res.ToArray();
        }
        public int[] GetPrime()
        {
            List<int> res = new List<int>();
            foreach (int num in this.array)
            {
                if (IsPrime(num))
                {
                    res.Add(num);
                }
            }
            return res.ToArray();
        }
        private bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        public int[] GetFibonacci()
        {
            List<int> res = new List<int>();
            foreach (int num in this.array)
            {
                if (IsFibonacci(num))
                {
                    res.Add(num);
                }
            }
            return res.ToArray();
        }
        private bool IsFibonacci(int num)
        {
            int a = 0;
            int b = 1;
            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 9, 10, 11, 16, 48, 16 };
            Array array = new Array(arr);
            ArrayDelegate arrayDelegate = new ArrayDelegate(array.GetOdd);
            foreach (var item in arrayDelegate())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arrayDelegate = new ArrayDelegate(array.GetEven);
            foreach (var item in arrayDelegate())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arrayDelegate = new ArrayDelegate(array.GetPrime);
            foreach (var item in arrayDelegate())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arrayDelegate = new ArrayDelegate(array.GetFibonacci);
            foreach (var item in arrayDelegate())
            {
                Console.Write(item + " ");
            }
        }
    }
}
