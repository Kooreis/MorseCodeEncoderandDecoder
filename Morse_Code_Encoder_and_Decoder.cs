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