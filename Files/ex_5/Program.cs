using System;
using System.IO;
using System.Linq;

namespace ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    sw.WriteLine(random.Next(-100000, 100000));
                }
            }

            try
            {
                var content = File.ReadAllLines("test.txt").Select(int.Parse).ToList();
                var posnum = content.Where(n => n > 0).Count();
                var negnum = content.Where(n => n < 0).Count();
                var twodignum = content.Where(n => n >= 10 && n < 100).Count();
                var fivedignum = content.Where(n => n >= 10000 && n < 100000).Count();
                SaveToFile(posnum, negnum, twodignum, fivedignum);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                throw;
            }
        }
        static void SaveToFile(int data1, int data2, int data3, int data4)
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                sw.WriteLine("Positive numbers: " + data1);
                sw.WriteLine("Negative numbers: " + data2);
                sw.WriteLine("2 digit numbers: " + data3);
                sw.WriteLine("5 digit numbers: " + data4);
            }
        }
    }
}
