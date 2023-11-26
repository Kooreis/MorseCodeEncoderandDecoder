```CSharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        private static Dictionary<char, string> _morseAlphabetDictionary;
        private static Dictionary<string, char> _morseAlphabetDictionaryReversed;

        static void Main(string[] args)
        {
            InitializeDictionary();

            Console.WriteLine("Enter a word to translate to Morse code:");
            string word = Console.ReadLine();
            string morseCode = TranslateTextToMorseCode(word);
            Console.WriteLine(morseCode);

            Console.WriteLine("Enter Morse code to translate to text:");
            string code = Console.ReadLine();
            string text = TranslateMorseCodeToText(code);
            Console.WriteLine(text);

            Console.ReadKey();
        }

        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."}
            };

            _morseAlphabetDictionaryReversed = _morseAlphabetDictionary.ToDictionary(x => x.Value, x => x.Key);
        }

        private static string TranslateTextToMorseCode(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in input.ToLower())
            {
                if (_morseAlphabetDictionary.ContainsKey(character))
                {
                    stringBuilder.Append(_morseAlphabetDictionary[character] + " ");
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("/ ");
                }
                else
                {
                    stringBuilder.Append(character + " ");
                }
            }

            return stringBuilder.ToString();
        }

        private static string TranslateMorseCodeToText(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string[] words = input.Split(new string[] { " / " }, StringSplitOptions.None);

            foreach (string word in words)
            {
                string[] characters = word.Split(' ');

                foreach (string character in characters)
                {
                    if (_morseAlphabetDictionaryReversed.ContainsKey(character))
                    {
                        stringBuilder.Append(_morseAlphabetDictionaryReversed[character]);
                    }
                    else
                    {
                        stringBuilder.Append(character);
                    }
                }

                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString().ToUpper();
        }
    }
}
```