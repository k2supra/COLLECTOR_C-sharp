using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;

namespace ex_21
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [Obsolete]
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LogManager.LoadConfiguration("nlog.config"); 
            string filepath = "text.txt";
            string text = File.ReadAllText(filepath);
            var sentences = SplitSentences(text);
            Console.WriteLine("\nSentences with at least one lowercase English letter");
            DisplayAndLogSentences(sentences, "[a-z]", "Sentences with at least one lowercase English letter");

            Console.WriteLine("2. Sentences with at least one digit");
            DisplayAndLogSentences(sentences, "[0-9]", "Sentences with at least one digit");

            Console.WriteLine("3. Sentences with at least one uppercase English letter");
            DisplayAndLogSentences(sentences, "[A-Z]", "Sentences with at least one uppercase English letter");
        }
        static List<string> SplitSentences(string text)
        {
            var sentences = new List<string>();
            var matches = Regex.Matches(text, @"[^.!?]*[.!?]");

            foreach (Match match in matches)
            {
                sentences.Add(match.Value.Trim());
            }

            return sentences;
        }

        static void DisplayAndLogSentences(List<string> sentences, string pattern, string logMessage)
        {
            var regex = new Regex(pattern);
            Console.WriteLine($"\n{logMessage}:");
            logger.Info(logMessage);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                    logger.Info(sentence);
                }
            }
        }
    }
}
