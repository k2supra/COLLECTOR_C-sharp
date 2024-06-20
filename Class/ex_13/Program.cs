using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13
{
    class DictionaryEnFr
    {
        private Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public void AddWord(string en_word, List<string> fr_words)
        {
            if (dict.ContainsKey(en_word))
            {
                Console.WriteLine("Word already exists.");
            }
            else
            {
                dict.Add(en_word, fr_words);
                Console.WriteLine("Word and translations added successfully.");
            }
        }
        public void RemoveWord(string englishWord)
        {
            if (dict.ContainsKey(englishWord))
            {
                dict.Remove(englishWord);
                Console.WriteLine("Word removed successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }
        public void RemoveTranslation(string englishWord, string translation)
        {
            if (dict.ContainsKey(englishWord))
            {
                dict[englishWord].Remove(translation);
                Console.WriteLine("Translation removed successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }
        public void UpdateWord(string oldWord, string newWord)
        {
            if (dict.ContainsKey(oldWord))
            {
                List<string> translations = dict[oldWord];
                dict.Remove(oldWord);
                dict.Add(newWord, translations);
                Console.WriteLine("Word updated successfully.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }
        public void UpdateTranslation(string englishWord, string oldTranslation, string newTranslation)
        {
            if (dict.ContainsKey(englishWord))
            {
                int index = dict[englishWord].FindIndex(t => t.Equals(oldTranslation, StringComparison.OrdinalIgnoreCase));
                if (index != -1)
                {
                    dict[englishWord][index] = newTranslation;
                    Console.WriteLine("Translation updated successfully.");
                }
                else
                {
                    Console.WriteLine("Translation not found.");
                }
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }
        public void GetTranslations(string word)
        {
            if (dict.ContainsKey(word))
            {
                Console.WriteLine($"Translation of {word}: ");
                foreach (var item in dict[word])
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Word not found");
            }
        }
        public void DisplayAllWords()
        {
            foreach (var entry in dict)
            {
                Console.WriteLine($"English word: {entry.Key}, French translations: {string.Join(", ", entry.Value)}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryEnFr dictionaryEnFr = new DictionaryEnFr();
            dictionaryEnFr.AddWord("hello", new List<string> { "bonjour", "salut" });
            dictionaryEnFr.AddWord("goodbye", new List<string> { "au revoir", "adieu" });
            dictionaryEnFr.DisplayAllWords();
            dictionaryEnFr.GetTranslations("hello");
            dictionaryEnFr.UpdateWord("hello", "hi");
            dictionaryEnFr.UpdateTranslation("hi", "bonjour", "salutation");
            dictionaryEnFr.DisplayAllWords();
            dictionaryEnFr.RemoveTranslation("hi", "salutation");
            dictionaryEnFr.RemoveWord("goodbye");
            dictionaryEnFr.DisplayAllWords();
        }
    }
}
