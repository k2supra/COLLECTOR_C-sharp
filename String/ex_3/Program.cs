using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) { Console.Write($"Enter {i + 1} number: "); arr[i] = int.Parse(Console.ReadLine()); }
            Console.Write("Enter a filter size: ");
            int filter_size = int.Parse(Console.ReadLine());
            int[] filter_arr = new int[filter_size];
            int new_size = size;
            for (int i = 0; i < filter_size; i++) { Console.Write($"Enter a {i + 1} filter number: "); filter_arr[i] = int.Parse(Console.ReadLine()); }
            int[] filtered_arr = filterArray(arr, filter_arr);
            for (int i = 0; i < filtered_arr.Length; i++)
            {
                Console.Write(filtered_arr[i] + " ");
            }
        }
        static int[] filterArray(int[] arr1, int[] arr2)
        {
            return arr1.Where(num => !arr2.Contains(num)).ToArray();
        }
    }
}
