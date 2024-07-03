using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_18
{
    class Magazine
    {
        public string Title { get; set; }
        public string Theme { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }
        public Magazine(string title, string theme, int pages, DateTime publishDate)
        {
            Title = title;
            Theme = theme;
            Pages = pages;
            PublishDate = publishDate;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Theme: {Theme}, Pages: {Pages}, Publis date: {PublishDate:d}";
        }
    }
    static class MagazineManager
    {
        private static List<Magazine> _magazines = new List<Magazine>();
        public static void setMagazines(List<Magazine> magazines) { _magazines = magazines;}
        public static bool More30()
        {
            return _magazines.All(m => m.Pages > 30);
        }
        public static bool AllOfThem()
        {
            return _magazines.All(m => m.Theme == "Fashion" || m.Theme == "Sport" || m.Theme == "Politic");
        }
        public static bool AboutGarden()
        {
            return _magazines.Any(m => m.Theme == "Garden");
        }
        public static bool AboutFishing()
        {
            return _magazines.Any(m => m.Theme == "Fishing");
        }
        public static bool AboutHunting()
        {
            return _magazines.Any(m => m.Theme.ToLower().Contains("hunting"));
        }
        public static void First2022()
        {
            Console.WriteLine($"First 2022 magazine is:\n {_magazines.FirstOrDefault(m => m.PublishDate.Year == 2022)}");
        }
        public static void LastAuto()
        {
            Console.WriteLine($"Last magazine that ends with auto is:\n {_magazines.LastOrDefault(m => m.Title.EndsWith("auto"))}");
        }
    }
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("\n\nTask 1");
            string[] surnames = { "William", "Jakes", "Oppy", "Ju", "Santy", "Jackob" };
            Console.WriteLine($"All surnames have 3+ letters: {string.Join(", ", surnames.All(s => s.Length > 3))}");
            Console.WriteLine($"All surnames have 3+ & < 10 letters: {string.Join(", ", surnames.All(s => s.Length > 3 && s.Length < 10))}");
            Console.WriteLine($"Any surnames that starts with letter \"W\": {string.Join(", ", surnames.Any(s => s.StartsWith("W")))}");
            Console.WriteLine($"Any surnames that ends with letter \"y\": {string.Join(", ", surnames.Any(s => s.EndsWith("y")))}");
            Console.WriteLine($"Surname == Orange ?: {surnames.Contains("Orange")}");
            Console.WriteLine($"First surname that has 6 letters: {surnames.FirstOrDefault(s => s.Length == 6)}");
            Console.WriteLine($"Last surname that has < 15 letters: {surnames.LastOrDefault(s => s.Length < 15)}");
        }
        static void Task2()
        {
            Console.WriteLine("\n\nTask 2");
            var magazines = new List<Magazine>
            {
                new Magazine("Title1", "Politic", 56, DateTime.Parse("2024-12-12")),
                new Magazine("Title2", "Sport", 42, DateTime.Parse("2024-12-12")),
                new Magazine("Title3", "HUNTING", 5, DateTime.Parse("2024-12-12")),
                new Magazine("Title4", "Fashion", 27, DateTime.Parse("2024-12-12")),
                new Magazine("Title5", "Fantasy", 90, DateTime.Parse("2022-12-12")),
                new Magazine("Title6", "Fishing", 3, DateTime.Parse("2024-12-12")),
            };
            MagazineManager.setMagazines(magazines);
            Console.WriteLine($"All magazines have 30+ pages: {MagazineManager.More30()}");
            Console.WriteLine($"All magazines are about politic, fashion or sport: {MagazineManager.AllOfThem()}");
            Console.WriteLine($"Any magazine is about garden: {MagazineManager.AboutGarden()}");
            Console.WriteLine($"Any magazine is about fishing: {MagazineManager.AboutFishing()}");
            Console.WriteLine($"Any magazine is about hunting: {MagazineManager.AboutHunting()}");
            MagazineManager.First2022();
            MagazineManager.LastAuto();
        }
        static void Main(string[] args)
        {

            Task1();
            Task2();
        }
    }
}
