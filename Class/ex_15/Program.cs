using Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    enum Buttons
    {
        ShowAllDictionaries = 1,
        NewDictionary,
        AddWord,
        AddTranslation,
        RemoveWord,
        RemoveTranslation,
        UpdateWord,
        UpdateTranslation,
        FindTranslation,
        ShowAllData,
        Exit = 0
    }

    class Program : AllDictionaries
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Menu();
        }
        public static void Menu()
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("    <<<<<Welcome>>>>>");
                Console.Write(
                    "1. Show all dictionaries\n" +
                    "2. Create new dictionary\n" +
                    "0. Exit\n" +
                    "Your choice: "
                );
                byte ch = byte.Parse(Console.ReadLine());
                if (ch >= 0 && ch < 3)
                {
                    Buttons buttons = (Buttons)ch;
                    switch (buttons)
                    {
                        case Buttons.ShowAllDictionaries:
                            {
                                if (GetAllDictionaries().Length == 0)
                                {
                                    Console.WriteLine("\nNone :(");
                                }
                                else
                                {
                                    Console.WriteLine("\nAll dictionaries\n");
                                    int number = 1;
                                    foreach (string file in GetAllDictionaries()) { Console.WriteLine($"{number} - {file}"); number++; }
                                    EnteringDictionary(GetAllDictionaries().Length);
                                }
                            }
                            break;
                        case Buttons.NewDictionary:
                            {
                                Console.Write("\nEnter word language: ");
                                string language1 = Console.ReadLine();
                                Console.Write("Enter translation language: ");
                                string language2 = Console.ReadLine();
                                LanguageDictionary languageDictionary = new LanguageDictionary(language1, language2);
                            }
                            break;
                        case Buttons.Exit: { t = false; } break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong choice");
                }
            }
        }
        public static void DictionaryOptions(LanguageDictionary languageDictionary)
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine($"\n<<<<<Space: {languageDictionary.Language_language}>>>>>");
                Console.WriteLine("\t<<<<<Options>>>>>");
                Console.Write(
                    "3. Add new word\n" +
                    "4. Add new translation\n" +
                    "5. Remove word\n" +
                    "6. Remove translation\n" +
                    "7. Update word\n" +
                    "8. Update translation\n" +
                    "9. Find translation\n" +
                    "10. Show all data\n" +
                    "0. Exit\n" +
                    "Your choice: "
                );
                byte ch = byte.Parse(Console.ReadLine());
                if (ch > 2 && ch < 11 || ch == 0)
                {
                    Buttons buttons = (Buttons)ch;
                    switch (buttons)
                    {
                        case Buttons.AddWord:
                            {
                                Console.Write("\n\nEnter a word: ");
                                string word = Console.ReadLine();
                                Console.WriteLine("Enter translations (enter empty line to stop):");
                                List<string> translation = new List<string>();
                                string tr;
                                while (true)
                                {
                                    tr = Console.ReadLine();
                                    if (string.IsNullOrEmpty(tr))
                                    {
                                        break;
                                    }
                                    translation.Add(tr);
                                }
                                languageDictionary.AddWord(word, translation);
                            }
                            break;
                        case Buttons.AddTranslation:
                            {
                                Console.Write("\nEnter the word to add translations to: ");
                                string word = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(word))
                                {
                                    Console.WriteLine("Enter translations (enter empty line to stop):");
                                    List<string> translations = new List<string>();
                                    string tr;
                                    while (true)
                                    {
                                        tr = Console.ReadLine();
                                        if (string.IsNullOrWhiteSpace(tr))
                                        {
                                            break;
                                        }
                                        translations.Add(tr);
                                    }
                                    languageDictionary.AddTranslation(word, translations);
                                }
                                else
                                {
                                    Console.WriteLine("\nWord cannot be empty.");
                                }
                            }
                            break;
                        case Buttons.RemoveWord:
                            {
                                Console.Write("\nEnter the word to delete: ");
                                string word = Console.ReadLine();
                                languageDictionary.RemoveWord(word);
                            }
                            break;
                        case Buttons.RemoveTranslation:
                            {
                                Console.Write("\nEnter the word: ");
                                string word = Console.ReadLine();
                                Console.Write("Enter the translation to delete: ");
                                string tr = Console.ReadLine();
                                languageDictionary.RemoveTranslation(word, tr);
                            }
                            break;
                        case Buttons.UpdateWord:
                            {
                                Console.Write("\nEnter the old word: ");
                                string old_word = Console.ReadLine();
                                Console.Write("Enter the new word: ");
                                string new_word = Console.ReadLine();
                                languageDictionary.UpdateWord(old_word, new_word);
                            }
                            break;
                        case Buttons.UpdateTranslation:
                            {
                                Console.Write("\nEnter word: ");
                                string word = Console.ReadLine();
                                Console.Write("Enter old translation: ");
                                string old_translation = Console.ReadLine();
                                Console.Write("Enter new translation: ");
                                string new_translation = Console.ReadLine();
                                languageDictionary.UpdateTranslation(word, old_translation, new_translation);
                            }
                            break;
                        case Buttons.FindTranslation:
                            {
                                Console.Write("\nEnter a word to find translation: ");
                                string word = Console.ReadLine();
                                languageDictionary.FindTranslation(word);
                            }
                            break;
                        case Buttons.ShowAllData:
                            {
                                Console.WriteLine($"Data in {languageDictionary.Language_language} dicionary: ");
                                languageDictionary.ShowAllData();
                            }
                            break;
                        case Buttons.Exit: { t = false; } break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong choice");
                }
            }
        }
        public static object EnteringDictionary(int amount)
        {
            Console.WriteLine();
            Console.Write(
                "1. Enter dictionary\n" +
                "2. Leave\n" +
                "Your choice: "
            );
            byte ch = byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.Write("\nChoose a number of dictionary to enter: ");
                        byte num = byte.Parse(Console.ReadLine());
                        if (num > 0 && num <= amount)
                        {
                            string[] lang = GetAllDictionaries()[num - 1].Split('-', ' ');
                            var dict = new LanguageDictionary($"{lang[0]}-{lang[1]}-dictionary.txt");
                            DictionaryOptions(dict);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Leave");
                    }
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
