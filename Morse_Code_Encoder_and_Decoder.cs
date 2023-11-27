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
