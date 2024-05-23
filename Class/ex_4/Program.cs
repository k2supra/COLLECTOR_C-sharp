using System;
using System.Collections.Generic;

namespace MorseCodeTranslator
{
    public class MorseCode
    {
        private readonly Dictionary<char, string> TextToMorse = new Dictionary<char, string>
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." }, { 'F', "..-." },
            { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
            { 'M', "--" }, { 'N', "-." }, { 'O', "---" }, { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." },
            { 'S', "..." }, { 'T', "-" }, { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
            { 'Y', "-.--" }, { 'Z', "--.." }, { '0', "-----" }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" },
            { '4', "....-" }, { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." },
            { ' ', "/" }
        };

        private readonly Dictionary<string, char> MorseToText = new Dictionary<string, char>();

        public MorseCode()
        {
            foreach (var kvp in TextToMorse)
            {
                MorseToText[kvp.Value] = kvp.Key;
            }
        }

        public string TranslateToMorse(string input)
        {
            input = input.ToUpper();
            var morseCode = new List<string>();
            foreach (var character in input)
            {
                if (TextToMorse.ContainsKey(character))
                {
                    morseCode.Add(TextToMorse[character]);
                }
                else
                {
                    throw new ArgumentException($"Character '{character}' cannot be translated to Morse code.");
                }
            }
            return string.Join(" ", morseCode);
        }

        public string TranslateFromMorse(string input)
        {
            var words = input.Split('/');
            var translatedText = new List<string>();

            foreach (var word in words)
            {
                var morseCharacters = word.Trim().Split(' ');
                foreach (var morseChar in morseCharacters)
                {
                    if (MorseToText.ContainsKey(morseChar))
                    {
                        translatedText.Add(MorseToText[morseChar].ToString());
                    }
                    else
                    {
                        throw new ArgumentException($"Morse code '{morseChar}' cannot be translated to text.");
                    }
                }
                translatedText.Add(" ");
            }
            return string.Join("", translatedText).Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MorseCode morse = new MorseCode();
            Console.WriteLine("Enter text to translate to Morse code:");
            string textInput = Console.ReadLine();
            try
            {
                string morseCode = morse.TranslateToMorse(textInput);
                Console.WriteLine($"Morse code: {morseCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nEnter Morse code to translate to text (use '/' for spaces):");
            string morseInput = Console.ReadLine();
            try
            {
                string translatedText = morse.TranslateFromMorse(morseInput);
                Console.WriteLine($"Translated text: {translatedText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
