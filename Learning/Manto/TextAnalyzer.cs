using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Manto
{
    public class TextAnalyzer
    {
        private int _wordCount = 0;
        private Dictionary<string, int> _words;
        public Dictionary<char, int> _letters;
        public TextAnalyzer()
        {
            _words = new();
            _letters = new();
        }

        public int AnalyzedText(string fileName)
        {
            try
            {
                using StreamReader reader = new(fileName);

                while (!reader.EndOfStream)
                {
                    var symbol = reader.Read();
                    if (symbol != 10 && symbol != 13)
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
            }
            return 1;
        
        
        }

    }
}
