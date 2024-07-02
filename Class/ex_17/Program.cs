using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_17
{
    public class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public Device(string name, string manufacturer, int price) 
        { 
            Name = name; Manufacturer = manufacturer; Price = price; 
        }
        public override string ToString()
        {
            return $"Name: {Name}, Manufacturer: {Manufacturer}, Price: {Price}";
        }
    }
    public static class DeviceOperations
    {
        public static List<Device> Difference(List<Device> firstList, List<Device> secondList)
        {
            return firstList.Where(d => !secondList.Any(d2 => d2.Manufacturer == d.Manufacturer)).ToList();
        }

        public static List<Device> Intersection(List<Device> firstList, List<Device> secondList)
        {
            return firstList.Where(d => secondList.Any(d2 => d2.Manufacturer == d.Manufacturer)).ToList();
        }

        public static List<Device> Union(List<Device> firstList, List<Device> secondList)
        {
            var unionList = new List<Device>(firstList);
            unionList.AddRange(secondList.Where(d => !firstList.Any(d2 => d2.Manufacturer == d.Manufacturer)));
            return unionList;
        }
    }
    internal class Program
    {
        static int CharNumbers(int number)
        {
            int sum = 0;
            foreach (char item in number.ToString())
            {
                sum += int.Parse(item.ToString());
            }
            return sum;
        }
        static void Task1()
        {
            int[] ints = { 121, 75, 81 };
            int[] changed = (from i1 in ints orderby CharNumbers(i1) descending select i1).ToArray();
            foreach (int i in changed) {Console.WriteLine(i); }
        }
        static void Task2()
        {
            int[] ints1 = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9 };
            int[] ints2 = { 1, 2, 5, 7, 8, 11, 25 };
            Console.WriteLine($"Difference: {string.Join(", ", from a1 in ints1 where !ints2.Contains(a1) select a1)}");
            Console.WriteLine($"Intersection: {string.Join(", ", from a1 in ints1 join a2 in ints2 on a1 equals a2 select a1)}");
            Console.WriteLine($"Union: {string.Join(", ", (from a1 in ints1 select a1).Union(from a2 in ints2 select a2))}");
            Console.WriteLine($"Unique: {string.Join(", ", (from a1 in ints1 select a1).Union(from a12 in ints1 select a12))}");
        }
        static void Task3()
        {
            var devices1 = new List<Device>
        {
            new Device("Device1", "ManufacturerA", 100),
            new Device("Device2", "ManufacturerB", 200),
            new Device("Device3", "ManufacturerC", 300)
        };

            var devices2 = new List<Device>
        {
            new Device("Device4", "ManufacturerB", 150),
            new Device("Device5", "ManufacturerD", 250),
            new Device("Device6", "ManufacturerE", 350)
        };

            var difference = DeviceOperations.Difference(devices1, devices2);
            var intersection = DeviceOperations.Intersection(devices1, devices2);
            var union = DeviceOperations.Union(devices1, devices2);

            Console.WriteLine("Difference:");
            difference.ForEach(d => Console.WriteLine(d));

            Console.WriteLine("\nIntersection:");
            intersection.ForEach(d => Console.WriteLine(d));

            Console.WriteLine("\nUnion:");
            union.ForEach(d => Console.WriteLine(d));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1");
            Task1();
            Console.WriteLine("\nTask 2");
            Task2();
            Console.WriteLine("\nTask 3");
            Task3();
        }
    }
}
