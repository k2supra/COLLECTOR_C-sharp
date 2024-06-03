using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    class Actions
    {
        public void TimeNow()
        {
            Console.WriteLine($"Current time is {DateTime.Now:t}");
        }
        public void DateNow()
        {
            Console.WriteLine($"Current time is {DateTime.Now:d}");
        }
        public void DayOfWeekNow()
        {
            Console.WriteLine($"Current time is {DateTime.Now:dddd}");
        }
        public int RectangleArea(int side1, int side2)
        {
            Console.WriteLine($"Area of square is {side1 * side2}");
            return side1 * side2;
        }
        public double TriangleArea(int side1, int side2)
        {
            Console.WriteLine($"Area of square is {side1 * side2/2}");
            return side1 * side2 / 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();

            Action displayTime = actions.TimeNow;
            Action displayDate = actions.DateNow;
            Action displayDayOfTheWeek = actions.DayOfWeekNow;
            Func<int, int, int> calcRectangle = actions.RectangleArea;
            Func<int, int, double> calcTriangle = actions.TriangleArea;

            displayTime();
            displayDate();
            displayDayOfTheWeek();

            calcRectangle(5, 2);
            calcTriangle(3, 2); 
        }
    }
}
