using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    class Passport
    {
        private string fullname;
        private DateTime date;
        private string number;

        public string Fullname
        {
            get { return fullname; }
            set 
            {
                try
                {
                    fullname = value;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine($"Error: {fex.Message}");
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                try
                {
                    date = value;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine($"Error: {fex.Message}");
                }
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                try
                {
                    number = value;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine($"Error: {fex.Message}");
                }

            }
        }
        public void display()
        {
            Console.WriteLine($"Name: {Fullname}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Date: {Date}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport pass = new Passport();
            pass.Number = "6351125";
            pass.Fullname = "Abooba Big";
            pass.Date = DateTime.Parse("24.05.2025");

            pass.display();
        }
    }
}
