using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "test.txt";
            string moderationfile = "moderation.txt";

            string content = File.ReadAllText(file);
            string[] mod = File.ReadAllLines(moderationfile);
            foreach (var item in mod)
            {
                content = Regex.Replace(content, $@"\b{Regex.Escape(item)}\b", new string('*', item.Length), RegexOptions.IgnoreCase);
            }
            File.WriteAllText(file, content);
            Console.WriteLine("Moderation completed.");
        }
    }
}
