using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dictionary
{
    interface IDictionary
    {
        void AddWord(string word, List<string> translation);
        void AddTranslation(string word, List<string> translation);
        void RemoveWord(string word);
        void RemoveTranslation(string word, string translation);
        void UpdateWord(string old_word, string new_word);
        void UpdateTranslation(string word, string old_translation, string new_translation);
        void FindTranslation(string word);
        void ShowAllData();
    }
    class LanguageDictionary : IDictionary
    {
        private Dictionary<string, List<string>> language_dictionary;
        public string Language_language { get; set; }
        public LanguageDictionary(string language1, string language2)
        {
            this.Language_language = $"{language1}-{language2}-dictionary.txt";
            CreateFile();
        }
        public LanguageDictionary(string filename)
        {
            this.Language_language = filename;
            this.language_dictionary = new Dictionary<string, List<string>>();
            LoadFromFile();
        }
        public void AddWord(string word, List<string> translation)
        {
            if (!language_dictionary.ContainsKey(word))
            {
                language_dictionary.Add(word, translation);
                SaveToFile();
            }
        }
        public void AddTranslation(string word, List<string> translation)
        {
            if (language_dictionary.ContainsKey(word))
            {
                foreach (string tr in translation)
                {
                    if (!language_dictionary[word].Contains(tr))
                    {
                        language_dictionary[word].Add(tr);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nWord not found in dictionary.");
            }
            SaveToFile();
        }
        public void RemoveWord(string word)
        {
            if (language_dictionary.Remove(word))
            {
                SaveToFile();
            }
            else
            {
                Console.WriteLine("\nWord not found.");
            }
        }
        public void RemoveTranslation(string word, string translation)
        {
            if (language_dictionary.ContainsKey(word))
            {
                if (language_dictionary[word].Remove(translation))
                {
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine("\nTranslation not found.");
                }
            }
            else
            {
                Console.WriteLine("\nWord does not exist.");
            }
        }
        public void UpdateWord(string old_word, string new_word)
        {
            if (language_dictionary.ContainsKey(old_word))
            {
                var translations = language_dictionary[old_word];
                language_dictionary.Remove(old_word);
                language_dictionary[new_word] = translations;
                SaveToFile();
            }
            else
            {
                Console.WriteLine("\nWord not found.");
            }
        }
        public void UpdateTranslation(string word, string old_translation, string new_translation)
        {
            if (language_dictionary.ContainsKey(word))
            {
                var translations = language_dictionary[word];
                int index = translations.IndexOf(old_translation);
                if (index != -1)
                {
                    translations[index] = new_translation;
                    SaveToFile();
                }
                else
                {
                    Console.WriteLine("\nTranslation not found.");
                }
            }
            else
            {
                Console.WriteLine("\nWord does not exist.");
            }
        }
        public void FindTranslation(string word)
        {
            if (language_dictionary.ContainsKey(word))
            {
                Console.Write($"\nTranslation of the word {word} is: ");
                foreach (var item in language_dictionary[word])
                {
                    Console.Write(item + ", ");
                }
            }
        }
        public void ShowAllData()
        {
            if (language_dictionary.Count == 0)
            {
                Console.WriteLine("\nDictionary is empty");
            }
            else
            {
                Console.WriteLine("\nDictionary data: ");
                foreach (var item in language_dictionary)
                {
                    Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
                }
            }
        }
        public void CreateFile()
        {
            if (File.Exists(Language_language))
            {
                Console.WriteLine("\nThis dictioanry is already exists");
            }
            else
            {
                using (FileStream fs = new FileStream(Language_language, FileMode.OpenOrCreate)) { }
            }
        }
        private void LoadFromFile()
        {
            if (File.Exists(Language_language))
            {
                foreach (var line in File.ReadLines(Language_language, Encoding.UTF8))
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        var word = parts[0].Trim();
                        var translations = parts[1].Split(',').Select(t => t.Trim()).ToList();
                        language_dictionary[word] = translations;
                    }
                }
            }
        }
        private void SaveToFile()
        {
            using (var writer = new StreamWriter(Language_language, false, Encoding.UTF8))
            {
                foreach (var item in language_dictionary)
                {
                    writer.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
                }
            }
        }
    }
    public class AllDictionaries
    {
        public static string[] GetAllDictionaries()
        {
            try
            {
                DirectoryInfo directory_info = new DirectoryInfo(".");
                FileInfo[] fileInfo = directory_info.GetFiles();
                List<string> dictionaries = new List<string>();
                foreach (FileInfo file in fileInfo)
                {
                    if (file.Name.Contains("dictionary"))
                    {
                        dictionaries.Add(Path.GetFileNameWithoutExtension(file.Name));
                    }
                }
                return dictionaries.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}
