using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7
{
    abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Worker(string name, int age) { Name = name; Age = age; }
        public abstract void print();
    }
    class President : Worker
    {
        public President(string name, int age) : base(name, age) { }

        public override void print()
        {
            Console.WriteLine($"President: {Name}, Age: {Age}");
        }
    }
    class Security : Worker
    {
        public Security(string name, int age) : base(name, age) { }

        public override void print()
        {
            Console.WriteLine($"Security: {Name}, Age: {Age}");
        }
    }
    class Manager : Worker
    {
        public Manager(string name, int age) : base(name, age) { }

        public override void print()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}");
        }
    }
    class Engineer : Worker
    {
        public Engineer(string name, int age) : base(name, age) { }

        public override void print()
        {
            Console.WriteLine($"Engineer: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new President("Alice", 50),
                new Security("Bob", 35),
                new Manager("Charlie", 40),
                new Engineer("Dave", 30)
            };
            foreach (Worker worker in workers)
            {
                worker.print();
            }
        }
    }
}
