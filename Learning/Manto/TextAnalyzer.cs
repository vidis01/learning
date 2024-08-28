namespace Learning.Manto
{
    public class TextAnalyzer
    {
        public Dictionary<string, int> _words;
        public Dictionary<char, int> _letters;
        private string _word = "";

        public TextAnalyzer()
        {
            _words = new();
            _letters = new();
        }
        private bool IsWordEndSymbol(int symbol)
        {
            switch (symbol)
            {
                case 03: //END OF TEXT
                case 10: //line feed
                case 13: //cr
                case 32: //space
                case 44: //comma ,
                case 46: //dot .
                case 58: //colon :
                case 59: //semicolon ;
                case 60: //<
                case 61: //=
                case 62:  //>
                case 63: //?
                case 64: //@
                    return true;
                default:
                    return false;
            }
        }
        private void CountingHowManyDifferentWordsTextHave(int symbol)
        {
            if (!IsWordEndSymbol(symbol))
            {
                _word += (char)symbol;
            }
            else
            {
                if (_words.ContainsKey(_word))
                {
                    _words[_word]++;
                }
                else
                {
                    _words.Add(_word, 1);
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
        private void CountingHowManyDifferentLettersTextHave(int symbol)
        {
            if (_letters.ContainsKey((char)symbol))
            {
                _letters[(char)symbol]++;
            }
            else
            {
                _letters.Add((char)symbol, 1);
            }
        }
        private int CountWovels()
        {
            int totalWovelCount = 0;

            foreach (var item in _letters)
            {
                switch (char.ToLower(item.Key))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'u':
                    case 'o':
                        totalWovelCount += item.Value;
                        break;
                    default:
                        break;
                }
            }
            return totalWovelCount;
        }
        private int CountConsonants()
        {
            int totalConsonantsCount = 0;
            foreach (var item in _letters)
            {
                switch (char.ToLower(item.Key))
                {
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
                        totalConsonantsCount += item.Value;
                        break;
                    default:
                        break;
                }
            }
            return totalConsonantsCount;
        }
        private int CountPunctuations()
        {
            int totalPunctuationsCount = 0;

            foreach (var item in _letters)
            {
                for (int i = 32; i <= 46; i++)
                {
                    if ((int)item.Key == i)
                    {
                        totalPunctuationsCount += item.Value;
                    }
                }
            }
            return totalPunctuationsCount;
        }
        public void MenuChoice()
        {
            bool on = true;
            while (on)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number to choose from actions bellow:");
                Console.WriteLine("1. Go to Detailed Summary");
                Console.WriteLine("2. Go to Quick Summary");
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
            Console.WriteLine($"Total Words: {CountTotalWords()}");
            Console.WriteLine($"Total Wovels: {CountWovels()}");
            Console.WriteLine($"Total Consonants: {CountConsonants()}");
            Console.WriteLine($"Total Punctuations: {CountPunctuations()}");
        }
        public void PrintDetailedSummary()
        {
            Console.WriteLine("Work in progress....");
        }
        public void AnalyzedText(string fileName)
        {
            try
            {
                using StreamReader reader = new(fileName);
 
                while (!reader.EndOfStream)
                {
                    var symbol = reader.Read();
                    if (symbol != 10 && symbol != 13)
                    {
                        CountingHowManyDifferentWordsTextHave(symbol);
                        CountingHowManyDifferentLettersTextHave(symbol);
                    }
                }
               CountingHowManyDifferentWordsTextHave(03); //kitu atveju paskutinio zodzio neissaugo nes nera nuorodos kad failas baigesi 
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
            }
        }
    }
}
//paskaiciuoti zodzius metodas+
//paskaiciuoti balses metodas+
//paskaiciuoti priebalses metodas+
//paskaiciuoti visa kita metodas+
//atspausdinti summary metodas+