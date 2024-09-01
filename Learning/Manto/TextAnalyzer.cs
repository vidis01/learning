using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
namespace Learning.Manto
{
    public class TextAnalyzer
    {
        private Dictionary<string, int> _words;
        private Dictionary<char, int> _letters;
        private Dictionary<char, int> _symbols;
        private Dictionary<char, int> _numbers;
        private Dictionary<char, int> _vowels;
        private Dictionary<char, int> _consonants;
        private Dictionary<char, int> _punctuations;
        private Dictionary<char, int> _miscSymbols;
        private string _word = "";
        private int _totalVowelsCount = 0;
        private int _totalConsonantsCount = 0;
        private int _totalPunctuationsCount = 0;
        private int _totalNumbersCount = 0;
        private int _miscSymbolsCount = 0;
        private readonly int _howManyLinesToPrint = 50;     //prints written amount of lines and then asks to either proceed or cancel printing

        public TextAnalyzer()
        {
            _words = new();
            _letters = new();
            _symbols = new();
            _numbers = new();
            _vowels = new();
            _consonants = new();
            _punctuations = new();
            _miscSymbols = new();
        }
        private bool IsWordEndSymbol(int symbol)
        {
            //switch (symbol)
            //{
            //    case 03: //END OF TEXT
            //    case 04: //END OF TRANSMISSION
            //    case 09: //TAB
            //    case 10: //line feed
            //    case 13: //cr
            //    case 32: //space
            //    case 44: //comma ,
            //    case 46: //dot .
            //    case 58: //colon :
            //    case 59: //semicolon ;
            //    case 60: //<
            //    case 61: //=
            //    case 62:  //>
            //    case 63: //?
            //    case 64: //@:
            //        return true;
            //    default:
            //        return false;
            //}
            if ((symbol < 65) || (symbol > 90 && symbol < 97) || (symbol > 122))
                return true;
            else
                return false;
        }
        private void AddUniqueWordsToDict(int symbol)
        {
            if (!IsWordEndSymbol(symbol))
            {
                _word += char.ToLower((char)symbol);
            }
            else
            {
                if (_word != "")
                {
                    if (_words.ContainsKey(_word))
                    {
                        _words[_word]++;
                    }
                    else
                    {
                        _words.Add(_word, 1);
                    }
                }
                _word = "";
            }
        }
        private int CountTotalWords()
        {
            int totalWordCount = 0;

            foreach (var item in _words)
            {
                totalWordCount += item.Value;
            }
            return totalWordCount;
        }
        private void AddEachSymbolToDict(int symbol)
        {
            char s = char.ToLower((char)symbol);
            if (_symbols.TryGetValue(s, out int value))
            {
                _symbols[s] = ++value;
            }
            else
            {
                _symbols.Add(s, 1);
            }
        }
        private void CountingAddingIndividualyEachSymbol()
        {
            foreach (var item in _symbols)
            {
                switch (char.ToLower(item.Key))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'u':
                    case 'o':
                    case 'y':
                        _totalVowelsCount += item.Value;
                        _letters.TryAdd(item.Key, item.Value);
                        _vowels.TryAdd(item.Key, item.Value);
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'z':
                        _totalConsonantsCount += item.Value;
                        _letters.TryAdd(item.Key, item.Value);
                        _consonants.TryAdd(item.Key, item.Value);
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        _totalNumbersCount += item.Value;
                        _numbers.TryAdd(item.Key, item.Value);
                        break;
                    default:
                        if ((int)item.Key >= 32 && (int)item.Key <= 46)
                        {
                            _totalPunctuationsCount += item.Value;
                            _punctuations.TryAdd(item.Key, item.Value);
                        }
                        else
                        {
                            _miscSymbolsCount += item.Value;
                            _miscSymbols.TryAdd(item.Key, item.Value);
                        }
                        break;
                }
            }
        }
        private static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please enter a number to choose from actions bellow:");
            Console.WriteLine("1. Go to Detailed Summary");
            Console.WriteLine("2. Go to Quick Summary");
        }
        public void MainMenuChoice()
        {
            bool on = true;
            while (on)
            {
                PrintMainMenu();

                CountingAddingIndividualyEachSymbol();
                var menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        PrintDetailedSummary();
                        on = false;
                        break;
                    case "2":
                        PrintQuickSummary();
                        on = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void PrintQuickSummary()
        {
            Console.Clear();
            Console.WriteLine("Quick summary");
            Console.WriteLine("==============");
            Console.WriteLine("Provided text file contains:");
            Console.WriteLine($"Total words: {CountTotalWords()}");
            Console.WriteLine($"Total unique words: {_words.Count}");
            Console.WriteLine($"Total wovels: {_totalVowelsCount}");
            Console.WriteLine($"Total consonants: {_totalConsonantsCount}");
            Console.WriteLine($"Total punctuations: {_totalPunctuationsCount}");
            Console.WriteLine($"Total miscellaneous symbols: {_miscSymbolsCount}");
            Console.WriteLine($"Total numbers: {_totalNumbersCount}");
        }
        public void PrintDetailedSelection(Dictionary<char, int> selectedDictionary, string selectionName)
        {  
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"    This shows all {selectionName} provided text have   ");
            Console.WriteLine("            and how many each of them there are          ");
            Console.WriteLine("**************************************************************");
            int howManyLines = _howManyLinesToPrint;
            foreach (var item in selectedDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} time(s);");
                howManyLines--;
                if (howManyLines == 0)
                {
                    Console.WriteLine("Do you want to continue printing?(\"y\" to continue)");
                    string? yn = Console.ReadLine();
                    if (yn != "y")
                    {
                        break;
                    }
                    else
                    {
                        howManyLines = _howManyLinesToPrint;
                    }
                }
            }
            Console.WriteLine("\n--------This is the end of list----------\n");
        }
        public void PrintDetailedSelection(Dictionary<string, int> selectedDictionary, string selectionName)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"    This shows all {selectionName} provided text have   ");
            Console.WriteLine("            and how many each of them there are          ");
            Console.WriteLine("**************************************************************");
            int howManyLines = _howManyLinesToPrint;
            int totalWordsLeftToPrint = _words.Count;

            foreach (var item in selectedDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} time(s);");
                howManyLines--;
                if (howManyLines == 0)
                {
                    totalWordsLeftToPrint -= _howManyLinesToPrint;
                    Console.WriteLine($"Do you want to continue printing?(\"y\" to continue)(Words left: {totalWordsLeftToPrint})");
                    string? yn = Console.ReadLine();
                    if (yn != "y")
                    {
                        break;
                    }
                    else
                    {
                        howManyLines = _howManyLinesToPrint;
                    }
                }
            }
            Console.WriteLine("\n--------This is the end of list----------\n");
        }
        public void PrintDetailedSummary()
        {
            bool keepShowingDetailedMenuChoices = true;

            while (keepShowingDetailedMenuChoices)
            {
                Console.Clear();

                PrintDetailedViewMenu();

                string? entry = Console.ReadLine();
                switch (entry)
                {
                    case "1":
                        PrintDetailedSelection(_letters, "letters");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "2":
                        PrintDetailedSelection(_vowels, "vowels");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "3":
                        PrintDetailedSelection(_consonants, "consonants");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "4":
                        PrintDetailedSelection(_punctuations, "punctuations");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "5":
                        PrintDetailedSelection(_miscSymbols, "miscellaneous symbols");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "6":
                        PrintDetailedSelection(_numbers, "numbers");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "7":
                        PrintDetailedSelection(_words, "words");
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "8":
                        MainMenuChoice();
                        keepShowingDetailedMenuChoices = false;
                        break;
                    default:
                        break;
                }
                if (!keepShowingDetailedMenuChoices)
                {
                    Console.WriteLine("Enter \"q\" to quit the program.");
                    Console.WriteLine("Press \"Enter\" to continue.");
                    entry = Console.ReadLine();
                    if (entry != "q") keepShowingDetailedMenuChoices = true;
                }
            }
        }
        public void AnalyzedText(string fileName)
        {
            try
            {
                using StreamReader reader = new(fileName);
                while (!reader.EndOfStream)
                {
                    int symbol = reader.Read();
                    AddUniqueWordsToDict(symbol);
                    AddEachSymbolToDict(symbol);
                }
                AddUniqueWordsToDict(03); //makes sure it reads last symbol of text 
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
            }
        }
        private static void PrintDetailedViewMenu()
        {
            Console.WriteLine("Choose the detailed view from below:");
            Console.WriteLine("1. Print all letters");
            Console.WriteLine("2. Print all wovels");
            Console.WriteLine("3. Print all consonants");
            Console.WriteLine("4. Print all punctuations");
            Console.WriteLine("5. Print all misc. left over symbols");
            Console.WriteLine("6. Print all numbers");
            Console.WriteLine("7. Print all words");
            Console.WriteLine("8. Back to Main menu");
        }
    }
}
