using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8
{
    class LoopQueue<T>
    {
        private T[] Values;
        private int head;
        private int tail;
        private int size;
        public LoopQueue(int size)
        {
            this.Values = new T[size];
            this.head = 0;
            this.tail = head;
            this.size = size;
        }
        public void Enqueue(T item) 
        {
            if (head == size - 1) 
            {
                Values[head] = item;
                head = 0;
            }
            else 
            {
                Values[head] = item;
                head++;
            }
        } 
        public T Dequue()
        {

            var temp = this.Values[tail];
            this.Values[tail] = default;
            tail++;
            return temp;
        }
        public T Peek() => this.Values[head];
        public void display()
        {
            foreach (T item in Values) { Console.WriteLine(item); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        public static void test()
        {
            LoopQueue<int> loopQueue = new LoopQueue<int>(5);
            loopQueue.Enqueue(1);
            loopQueue.Enqueue(2);
            loopQueue.Enqueue(3);
            loopQueue.Enqueue(4);
            loopQueue.Enqueue(5);
            loopQueue.Enqueue(6);
            loopQueue.Enqueue(7);
            loopQueue.display();
            Console.WriteLine($"Dequeue: {loopQueue.Dequue()}");
            Console.WriteLine($"Dequeue: {loopQueue.Dequue()}");
            loopQueue.display();
            Console.WriteLine();
            loopQueue.Enqueue(8);
            loopQueue.Enqueue(9);
            loopQueue.display();
            Console.WriteLine($"Dequeue: {loopQueue.Dequue()}");
            loopQueue.display();
        }
    }
}
