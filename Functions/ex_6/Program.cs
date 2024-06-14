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
            int a = 1;
            int b = 2;
            string sa = "string a";
            string sb = "string b";
            Console.WriteLine($"a: {a}\nb: {b}");
            Console.WriteLine($"sa: {sa}\nsb: {sb}");
            Swap<int>(ref a, ref b );
            Swap(ref sa, ref sb);
            Console.WriteLine($"a: {a}\nb: {b}");
            Console.WriteLine($"sa: {sa}\nsb: {sb}");
        }
        static void Swap<T>(ref T value1, ref T value2) 
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
