
using Learning.Classes;
using Learning.Enums;
namespace Learning.Manto
{
    public class TextAnalyzer
    {
        private readonly Dictionary<string, int> _words;
        private Dictionary<char, Symbol> _symbols;
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
            _symbols = new();
        }
        private bool IsWordEndSymbol(int symbol)
        {
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
            if (_symbols.TryGetValue(s, out _))
            {
                _symbols[s].Count++;
            }
            else
            {
                var simbolis = new Symbol();
                _symbols.Add(s, simbolis);
                
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
                        _totalVowelsCount += item.Value.Count;
                        item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.LETTER);
                        item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.VOWEL);
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
                        item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.LETTER);
                        item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.CONSONANT);
                        _totalConsonantsCount += item.Value.Count;
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

                        _totalNumbersCount += item.Value.Count;
                        item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.NUMBER);
                        break;
                    default:
                        if ((int)item.Key >= 32 && (int)item.Key <= 46)
                        {
                            _totalPunctuationsCount += item.Value.Count;
                            item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.PUNCTUATIONS);
                        }
                        else
                        {
                            _miscSymbolsCount += item.Value.Count;
                            item.Value.SymbolIndications.Add(Enums.SymbolTypeEnum.MISC);
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
        public void PrintDetailedSelection()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("          This shows all words provided text have             ");
            Console.WriteLine("            and how many each of them there are               ");
            Console.WriteLine("**************************************************************");
            int howManyLines = _howManyLinesToPrint;
            int totalWordsLeftToPrint = _words.Count;

            foreach (var item in _words)
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
        public void PrintDetailedSelection(SymbolTypeEnum symbolType)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"    This shows all {symbolType.ToString().ToLower()} provided text have   ");
            Console.WriteLine("            and how many each of them there are          ");
            Console.WriteLine("**************************************************************");
            int howManyLines = _howManyLinesToPrint;

            var selectedDictionary = _symbols.Where(s => s.Value.SymbolIndications.Contains(symbolType)).OrderBy(c => c.Key);

            foreach (var item in selectedDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count} time(s);");
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
                        PrintDetailedSelection(SymbolTypeEnum.LETTER);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "2":
                        PrintDetailedSelection(SymbolTypeEnum.VOWEL);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "3":
                        PrintDetailedSelection(SymbolTypeEnum.CONSONANT);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "4":
                        PrintDetailedSelection(SymbolTypeEnum.PUNCTUATIONS);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "5":
                        PrintDetailedSelection(SymbolTypeEnum.MISC);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "6":
                        PrintDetailedSelection(SymbolTypeEnum.NUMBER);
                        keepShowingDetailedMenuChoices = false;
                        break;
                    case "7":
                        PrintDetailedSelection();
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
