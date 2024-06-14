using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7
{
    class ListWithPriority<T>
    {
        private List<(T Value, int Priority)> list = new List<(T Value, int Priority)>();
        public void enqueue(T Value, int Priority)
        {
            list.Add((Value, Priority));
            list.Sort((x, y) => x.Priority.CompareTo(y.Priority));
        }
        public T dequeue()
        {
            var tempval = list[0].Value;
            list.RemoveAt(0);
            return tempval;
        }
        public int size() => list.Count;
        public bool isEmpty() => list.Count == 0;
        public T top() => list[0].Value;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListWithPriority<string> list = new ListWithPriority<string>();
            list.enqueue("hello", 1);
            list.enqueue("World", 2);
            list.enqueue("bb", 1);
            while (!list.isEmpty())
            {
                Console.WriteLine(list.dequeue());
            }
        }
    }
}
