using System;
using System.Collections.Generic;

namespace CafeQueue
{
    class Visitor
    {
        public string Name { get; set; }
        public bool HasReservation { get; set; }
        public DateTime ReservationTime { get; set; }

        public Visitor(string name, bool hasReservation = false, DateTime reservationTime = default)
        {
            Name = name;
            HasReservation = hasReservation;
            ReservationTime = reservationTime;
        }

        public override string ToString()
        {
            return HasReservation ? $"{Name} (Reservation at {ReservationTime.ToShortTimeString()})" : Name;
        }
    }

    class Cafe
    {
        private Queue<Visitor> regularQueue;
        private List<Visitor> reservedList;
        private int availableTables;

        public Cafe(int tables)
        {
            regularQueue = new Queue<Visitor>();
            reservedList = new List<Visitor>();
            availableTables = tables;
        }

        public void AddVisitor(Visitor visitor)
        {
            if (visitor.HasReservation)
            {
                reservedList.Add(visitor);
                Console.WriteLine($"{visitor.Name} added to the reservation list.");
            }
            else
            {
                regularQueue.Enqueue(visitor);
                Console.WriteLine($"{visitor.Name} added to the regular queue.");
            }

            AssignTables();
        }

        public void VisitorLeaves()
        {
            availableTables++;
            Console.WriteLine("A table is now available.");
            AssignTables();
        }

        private void AssignTables()
        {
            while (availableTables > 0)
            {
                if (reservedList.Count > 0)
                {
                    var nextReservedVisitor = reservedList[0];
                    reservedList.RemoveAt(0);
                    availableTables--;
                    Console.WriteLine($"{nextReservedVisitor.Name} with reservation is seated.");
                }
                else if (regularQueue.Count > 0)
                {
                    var nextVisitor = regularQueue.Dequeue();
                    availableTables--;
                    Console.WriteLine($"{nextVisitor.Name} from the queue is seated.");
                }
                else
                {
                    break;
                }
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("\nCurrent Regular Queue:");
            foreach (var visitor in regularQueue)
            {
                Console.WriteLine(visitor.Name);
            }

            Console.WriteLine("\nCurrent Reservation List:");
            foreach (var visitor in reservedList)
            {
                Console.WriteLine(visitor);
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe(3);

            cafe.AddVisitor(new Visitor("Alice"));
            cafe.AddVisitor(new Visitor("Bob"));
            cafe.AddVisitor(new Visitor("Charlie", true, DateTime.Now.AddMinutes(30))); 
            cafe.AddVisitor(new Visitor("David"));
            cafe.AddVisitor(new Visitor("Eve", true, DateTime.Now.AddMinutes(15))); 

            cafe.DisplayQueue();

            cafe.VisitorLeaves();
            cafe.VisitorLeaves();
            cafe.DisplayQueue();
        }
    }
}
