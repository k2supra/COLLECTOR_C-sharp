using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
    class SingleLinkedList<T>
    {
        private Node<T> head;
        public SingleLinkedList() { this.head = null; }
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null) head = newNode;
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Remove(T item)
        {
            if (head == null) return;
            if (head.Data.Equals(item))
            {
                head = head.Next;
                return;
            }
            Node<T> current = head;
            while (current.Next != null && !current.Next.Data.Equals(item))
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
        public void Find(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    Console.WriteLine($"Found {current.Data}");
                }
                current = current.Next;
            }
        }
        public void Display()
        {
            Node<T> current = head;
            Console.Write("Data: ");
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("List:");
            list.Display();
            Console.WriteLine("After removing 3:");
            list.Remove(3);
            list.Display();
            Console.WriteLine("\nFinding 5 in the list:");
            list.Find(5);
        }
    }
}
