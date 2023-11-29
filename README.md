# Python Documentation

# Morse Code Converter

This Python script provides a simple Morse Code converter. It allows the user to convert Morse Code to text and vice versa. The script does not require any external libraries, making it easy to run on any system with Python installed.

## Features

The script provides the following features:

1. **Morse to Text**: Converts Morse Code into readable text.
2. **Text to Morse**: Converts text into Morse Code.
3. **Quit**: Exits the program.

## How to Use

When you run the script, you will be presented with a menu with three options. 

1. If you choose option 1 (Morse to Text), you will be prompted to enter Morse Code. The Morse Code should be entered with each symbol separated by a space and each word separated by a slash (/). The script will then convert the Morse Code into text and display the result.

2. If you choose option 2 (Text to Morse), you will be prompted to enter text. The script will then convert the text into Morse Code and display the result. Each Morse Code symbol will be separated by a space and each word will be separated by a slash (/).

3. If you choose option 3 (Quit), the script will exit.

## Code Explanation

The script defines two functions: `morse_to_text` and `text_to_morse`.

- `morse_to_text`: This function takes a string of Morse Code as input and returns the corresponding text. It does this by splitting the input string into a list of Morse Code symbols, then iterating over this list and matching each symbol to its corresponding character in a predefined dictionary.

- `text_to_morse`: This function takes a string of text as input and returns the corresponding Morse Code. It does this by iterating over the input string and matching each character to its corresponding Morse Code symbol in a predefined dictionary.

The script then enters a loop where it displays the menu and prompts the user to make a choice. Depending on the user's choice, it calls the appropriate function and displays the result. The loop continues until the user chooses to quit.

## Note

This script only supports the English alphabet, numbers 0-9, and a limited set of punctuation marks. Other characters will not be converted correctly.

---

# C# Documentation

# Morse Code Translator in C#

This is a simple console application written in C# that translates English text to Morse code and vice versa.

## Description

The script initializes two dictionaries, one for English to Morse code and the other for Morse code to English. It then prompts the user to input a word or Morse code for translation. The translation is done by iterating through each character of the input and replacing it with its corresponding value in the dictionary.

## Libraries

The script uses the following libraries:

- `System`: This is a fundamental library in C# that provides base functionalities such as Console for input and output operations.

- `System.Collections.Generic`: This library is used for working with collections of objects. In this script, it is used for creating and manipulating dictionaries.

- `System.Linq`: This library provides methods for querying and manipulating data. In this script, it is used for reversing the dictionary.

- `System.Text`: This library contains classes that represent ASCII and Unicode character encodings. In this script, it is used for building a string in the translation methods.

- `System.Threading.Tasks`: This library provides types that simplify the work of writing concurrent and asynchronous code. It is not directly used in this script.

## Usage

To use this script, simply run it in a C# compatible environment. You will be prompted to enter a word for translation to Morse code, and then Morse code for translation to English. The translated result will be displayed in the console.

## Code Explanation

The script contains several methods:

- `Main()`: This is the entry point of the script. It initializes the dictionaries and handles user input and output.

- `InitializeDictionary()`: This method initializes the dictionaries used for translation.

- `TranslateTextToMorseCode(string input)`: This method translates English text to Morse code.

- `TranslateMorseCodeToText(string input)`: This method translates Morse code to English text.

## Note

This script only supports lowercase English letters and numbers from 0 to 9. Other characters will be output as they are.

---

# Java Documentation

# Morse Code Encoder and Decoder in Java

This Java script is a simple Morse Code encoder and decoder. It takes a string of text and converts it into Morse Code, and vice versa. The script uses two HashMaps to store the Morse Code values for each letter of the alphabet, and the corresponding letter for each Morse Code value.

## Libraries Used

### java.util.HashMap

This is a part of Java's collections framework. It provides the basic implementation of Map interface of Java. It stores the data in (Key, Value) pairs. To access a value one must know its key. HashMap is known as HashMap because it uses a technique called Hashing.

### java.util.Map

The Map interface maps unique keys to values. A key is an object that you use to retrieve a value at a later date. Given a key and a value, you can store the value in a Map object. After the value is stored, you can retrieve it by using its key.

## How the Script Works

The script first initializes two HashMaps, `TO_MORSE` and `FROM_MORSE`. `TO_MORSE` maps each letter of the alphabet to its corresponding Morse Code value, and `FROM_MORSE` maps each Morse Code value to its corresponding letter.

The `encode` method takes a string of text and converts it into Morse Code. It does this by iterating over each character in the string, converting it to uppercase, and then appending the corresponding Morse Code value from the `TO_MORSE` HashMap to a StringBuilder. The resulting Morse Code string is then returned.

The `decode` method takes a string of Morse Code and converts it back into text. It does this by splitting the Morse Code string into words (separated by three spaces), and then splitting each word into individual Morse Code values (separated by a single space). It then appends the corresponding letter from the `FROM_MORSE` HashMap to a StringBuilder for each Morse Code value. The resulting text string is then returned.

The `main` method demonstrates the use of the `encode` and `decode` methods by encoding and then decoding the string "HELLO WORLD".

---
