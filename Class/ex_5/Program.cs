using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    class Money
    {
        public int Whole { get; set; }
        public int Cents { get; set; }
        public Money(int whole = 0, int cents = 0) 
        {
            if (cents >= 100)
            {
                Whole = whole + cents / 100;
                Cents = cents & 100;
            }
            else
            {
                Whole = whole;
                Cents = cents;
            }
        }
        public void display()
        {
            Console.WriteLine($"{Whole}.{Cents:D2}");
        }
        public void setMoney(int wholePart, int cents)
        {
            if (cents >= 100)
            {
                Whole = cents / 100;
                Cents = cents % 100;
            }
            else
            {
                Whole = wholePart;
                Cents = cents;
            }
        }
    }
    class Product : Money
    {
        public string Name { get; set; }
        public Product(string name, int whole, int cents) : base(whole, cents)
        {
            Name = name;
        }
        public void DecreasePrice(int wholePart, int cents)
        {
            int totalCents = Whole * 100 + Cents;
            int decreaseAmount = wholePart * 100 + cents;

            if (totalCents >= decreaseAmount)
            {
                totalCents -= decreaseAmount;
                setMoney(totalCents / 100, totalCents % 100);
            }
            else
            {
                Console.WriteLine("Error: Decrease amount exceeds the current price.");
            }
        }
        public new void display()
        {
            Console.WriteLine($"Product: {Name}, Price: {Whole}.{Cents}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(5, 150);
            money.display();

            Product product = new Product("Apple", 5, 150);
            product.display();

            product.DecreasePrice(1, 50);
            product.display();

            product.DecreasePrice(3, 100);
            product.display();

            product.DecreasePrice(1, 200);
        }
    }
}
