using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
    class DoubleLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null) { head = newNode; tail = newNode; }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }
        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null) { head = newNode; tail = newNode; }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
        }
        public void RemoveItem(T item)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                if (current.Data.Equals(item))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                }
                current = current.Next;
            }
        }
        public void Contains(T item)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                if (current.Data.Equals(item))
                {
                    Console.WriteLine($"Contains!");
                }
                current = current.Next;
            }
        }
        public void Display()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            Console.WriteLine("List after adding elements:");
            list.Display();

            list.AddFirst(5);
            Console.WriteLine("List after adding an element at the beginning:");
            list.Display();

            list.RemoveItem(20);
            Console.WriteLine("List after removing element 20:");
            list.Display();

            list.Contains(10);
            list.Contains(50);
        }
    }
}
