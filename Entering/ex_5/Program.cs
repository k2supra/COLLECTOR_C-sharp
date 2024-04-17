using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in format dd.mm.yyyy:");
            string input = Console.ReadLine();

            try
            {
                string[] parts = input.Split('.');
                int day = Convert.ToInt32(parts[0]);
                int month = Convert.ToInt32(parts[1]);
                int year = Convert.ToInt32(parts[2]);

                string season = GetSeason(month);

                string dayOfWeek = GetDayOfWeek(day, month, year);

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }

        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Unknown";
            }
        }

        static string GetDayOfWeek(int day, int month, int year)
        {
            DateTime date = new DateTime(year, month, day);
            return date.ToString("dddd");
        }
    }
}
