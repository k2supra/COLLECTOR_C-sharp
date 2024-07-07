using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ex_20
{
    [Serializable]
    public class Article
    {
        public string Title { get; set; }
        public int CharacterCount { get; set; }
        public string Summary { get; set; }

        public Article() { }

        public Article(string title, int characterCount, string summary)
        {
            Title = title;
            CharacterCount = characterCount;
            Summary = summary;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Character Count: {CharacterCount}, Summary: {Summary}";
        }
    }

    [Serializable]
    public class Magazine
    {
        public string Title { get; set; }
        public string Theme { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }
        public List<Article> Articles { get; set; }

        public Magazine() { }

        public Magazine(string title, string theme, int pages, DateTime publishDate, List<Article> articles)
        {
            Title = title;
            Theme = theme;
            Pages = pages;
            PublishDate = publishDate;
            Articles = articles;
        }

        public override string ToString()
        {
            var articlesInfo = string.Join("\n", Articles.Select(a => $"  {a}"));
            return $"Title: {Title}, Theme: {Theme}, Pages: {Pages}, Publish Date: {PublishDate:d}\nArticles:\n{articlesInfo}";
        }
    }

    public static class Manager
    {
        private static List<Magazine> _magazines = new List<Magazine>();

        public static void Set(List<Magazine> magazines)
        {
            _magazines = magazines;
        }

        public static void Display()
        {
            foreach (var item in _magazines)
            {
                Console.WriteLine(item);
            }
        }

        public static void Serialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = File.Create("magazines.bin"))
            {
                binaryFormatter.Serialize(stream, _magazines);
            }
        }

        public static List<Magazine> Deserialize()
        {
            if (!File.Exists("magazines.bin"))
                return new List<Magazine>();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = File.OpenRead("magazines.bin"))
            {
                _magazines = (List<Magazine>)binaryFormatter.Deserialize(stream);
            }
            return _magazines;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var articles1 = new List<Article>
            {
                new Article("Article1", 1000, "Summary of Article1"),
                new Article("Article2", 1500, "Summary of Article2")
            };

            var articles2 = new List<Article>
            {
                new Article("Article3", 2000, "Summary of Article3"),
                new Article("Article4", 2500, "Summary of Article4")
            };

            var magazines = new List<Magazine>
            {
                new Magazine("Title1", "Politic", 56, DateTime.Parse("2024-12-12"), articles1),
                new Magazine("Title2", "Sport", 42, DateTime.Parse("2024-12-12"), articles2)
            };

            Manager.Set(magazines);
            Manager.Display();
            Manager.Serialize();
            Manager.Deserialize();
            Manager.Display();
        }
    }
}
