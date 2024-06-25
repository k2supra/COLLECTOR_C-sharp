using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.Write("Enter another word: ");
            string anotherword = Console.ReadLine();
            string filepath = "test.txt";
            string content = File.ReadAllText(filepath);
            int occ = CountOccurrences(content, word);
            if (occ == 0)
            {
                Console.WriteLine("The word '{0}' was not found in the file.", word);
            }
            else
            {
                string updatedContent = content.Replace(word, anotherword);
                File.WriteAllText(filepath, updatedContent);
                Console.WriteLine("The word '{0}' was replaced with '{1}' {2} times.", word, anotherword, occ);
            }
        }
        static int CountOccurrences(string text, string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return 0;
            }
            return Regex.Matches(text, Regex.Escape(word)).Count;
        }
    }
}
