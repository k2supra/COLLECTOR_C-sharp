using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ex_6
{
    class Poem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }
        public string Theme { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Theme: {Theme}\nText: {Text}\n";
        }
    }
    class PoemCollection
    {
        private List<Poem> poems = new List<Poem>();
        public void Add(Poem poem) { poems.Add(poem); }
        public void RemovePoem(string title)
        {
            var poem = poems.FirstOrDefault(x => x.Title == title);
            if (poem != null) { poems.Remove(poem); } else { Console.WriteLine("Poem not found."); }
        }
        public void UpdatePoem(string title, Poem newPoem)
        {
            var poem = poems.FirstOrDefault(p => p.Title == title);
            if (poem != null)
            {
                poem.Author = newPoem.Author;
                poem.Year = newPoem.Year;
                poem.Text = newPoem.Text;
                poem.Theme = newPoem.Theme;
            }
            else
            {
                Console.WriteLine("Poem not found.");
            }
        }
        public IEnumerable<Poem> SearchPoems(string searchTerm)
        {
            return poems.Where(p => p.Title.Contains(searchTerm) ||
                                     p.Author.Contains(searchTerm) ||
                                     p.Year.ToString().Contains(searchTerm) ||
                                     p.Text.Contains(searchTerm) ||
                                     p.Theme.Contains(searchTerm));
        }
        public void SaveToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(poems, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                poems = JsonSerializer.Deserialize<List<Poem>>(json);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        public IEnumerable<Poem> ReportByWord(string word) { return poems.Where(w => w.Text.Contains(word)); }
        public IEnumerable<Poem> ReportByYear(int year) { return poems.Where(y => y.Year == year); }
        public IEnumerable<Poem> ReportByLength(int length) { return poems.Where(l => l.Text.Length == length); }
        public IEnumerable<Poem> ReportByName(string name) { return poems.Where(n => n.Title == name); }
        public IEnumerable<Poem> ReportByAuthor(string author) { return poems.Where(a => a.Author == author); }
        public IEnumerable<Poem> ReportByTheme(string theme) { return poems.Where(t => t.Theme == theme); }
        public void PrintAllPoems()
        {
            foreach (var poem in poems)
            {
                Console.WriteLine(poem);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PoemCollection poemCollection = new PoemCollection();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Poem");
                Console.WriteLine("2. Remove Poem");
                Console.WriteLine("3. Update Poem");
                Console.WriteLine("4. Search Poem");
                Console.WriteLine("5. Save Poems to File");
                Console.WriteLine("6. Load Poems from File");
                Console.WriteLine("7. Show All Poems");
                Console.WriteLine("8. Report by Word in Text");
                Console.WriteLine("9. Report by Year");
                Console.WriteLine("10. Report by Length");
                Console.WriteLine("11. Report by Name");
                Console.WriteLine("12. Report by Author");
                Console.WriteLine("13. Report by Theme");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPoem(poemCollection);
                        break;
                    case 2:
                        RemovePoem(poemCollection);
                        break;
                    case 3:
                        UpdatePoem(poemCollection);
                        break;
                    case 4:
                        SearchPoem(poemCollection);
                        break;
                    case 5:
                        SavePoemsToFile(poemCollection);
                        break;
                    case 6:
                        LoadPoemsFromFile(poemCollection);
                        break;
                    case 7:
                        poemCollection.PrintAllPoems();
                        break;
                    case 8:
                        ReportByWordInText(poemCollection);
                        break;
                    case 9:
                        ReportByYear(poemCollection);
                        break;
                    case 10:
                        ReportByLength(poemCollection);
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void AddPoem(PoemCollection poemCollection)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter theme: ");
            string theme = Console.ReadLine();

            Poem poem = new Poem { Title = title, Author = author, Year = year, Text = text, Theme = theme };
            poemCollection.Add(poem);
        }
        static void RemovePoem(PoemCollection poemCollection)
        {
            Console.Write("Enter title of the poem to remove: ");
            string title = Console.ReadLine();
            poemCollection.RemovePoem(title);
        }

        static void UpdatePoem(PoemCollection poemCollection)
        {
            Console.Write("Enter title of the poem to update: ");
            string title = Console.ReadLine();

            Console.Write("Enter new author: ");
            string author = Console.ReadLine();
            Console.Write("Enter new year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter new text: ");
            string text = Console.ReadLine();
            Console.Write("Enter new theme: ");
            string theme = Console.ReadLine();

            Poem newPoem = new Poem { Author = author, Year = year, Text = text, Theme = theme };
            poemCollection.UpdatePoem(title, newPoem);
        }

        static void SearchPoem(PoemCollection poemCollection)
        {
            Console.Write("Enter search term: ");
            string searchTerm = Console.ReadLine();
            var results = poemCollection.SearchPoems(searchTerm);

            Console.WriteLine("Search results:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }

        static void SavePoemsToFile(PoemCollection poemCollection)
        {
            Console.Write("Enter file path to save poems: ");
            string filePath = Console.ReadLine();
            poemCollection.SaveToFile(filePath);
            Console.WriteLine("Poems saved to file.");
        }

        static void LoadPoemsFromFile(PoemCollection poemCollection)
        {
            Console.Write("Enter file path to load poems: ");
            string filePath = Console.ReadLine();
            poemCollection.LoadFromFile(filePath);
            Console.WriteLine("Poems loaded from file.");
        }
        static void ReportByWordInText(PoemCollection poemCollection)
        {
            Console.Write("Enter word to search in text: ");
            string word = Console.ReadLine();
            var results = poemCollection.ReportByWord(word);

            Console.WriteLine("Poems containing the word in text:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }
        static void ReportByAuthor(PoemCollection poemCollection)
        {
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            var results = poemCollection.ReportByWord(author);

            Console.WriteLine("Poems containing the author:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }
        static void ReportByName(PoemCollection poemCollection)
        {
            Console.Write("Enter word to search in name: ");
            string title = Console.ReadLine();
            var results = poemCollection.ReportByWord(title);

            Console.WriteLine("Poems containing the title:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }
        static void ReportByTheme(PoemCollection poemCollection)
        {
            Console.Write("Enter theme: ");
            string theme = Console.ReadLine();
            var results = poemCollection.ReportByTheme(theme);

            Console.WriteLine("Poems containing theme:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }

        static void ReportByYear(PoemCollection poemCollection)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            var results = poemCollection.ReportByYear(year);

            Console.WriteLine($"Poems written in the year {year}:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }

        static void ReportByLength(PoemCollection poemCollection)
        {
            Console.Write("Enter length of poem: ");
            int length = int.Parse(Console.ReadLine());
            var results = poemCollection.ReportByLength(length);

            Console.WriteLine($"Poems with length {length}:");
            foreach (var poem in results)
            {
                Console.WriteLine(poem);
            }
        }
    }
}
