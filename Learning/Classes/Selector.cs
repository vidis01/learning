namespace Learning.Classes
{
    public class WordSelectorFromFile : IWordSelector
    {
        private IReadFromfile _readFromfile;

        public WordSelectorFromFile(IReadFromfile readFromfile)
        {
            _readFromfile = readFromfile;
        }
        public string SelectWord(TopicEnum? topic)
        {
            var word = _readFromfile.GetWord();

            return word;
        }
    }

    public interface IWordSelector
    {
        string SelectWord(TopicEnum? topic);
    }

    public interface IDb
    {
        string GetWordFromTable();
    }

    public class Db : IDb
    {
        public string GetWordFromTable()
        {
            return "Zodis";
        }
    }

    public class WordSelectorFromDB : IWordSelector
    {
        private IDb _iDb;

        public WordSelectorFromDB(IDb idb)
        {
            _iDb = idb;
        }
        public string SelectWord(TopicEnum? topic)
        {
            string word = _iDb.GetWordFromTable();

            return word;
        }
    }

    public interface IReadFromfile
    {
        string GetWord();
    }

    public class ReadFromfile : IReadFromfile
    {
        public string GetWord()
        {
            return "Asilas";
        }
    }

    public class ReadFromFileLibrary : IReadFromfile
    {
        public string GetWord()
        {
            return "Begemotas";
        }
    }

    public enum TopicEnum
    {
        COUNTRIES = 1,
        CITIES,
        SEAS
    }

    public class Game
    {
        private IWordSelector _wordSelector;
        private TopicEnum? _topic;

        public Game(IWordSelector wordSelector)
        {
            _wordSelector = wordSelector;
        }

        public void Play()
        {
            _topic = ChooseTopic();
            string wordToGuess = _wordSelector.SelectWord(_topic);
            Console.WriteLine(wordToGuess);
        }

        private TopicEnum ChooseTopic()
        {
            var rand = new Random();
            return (TopicEnum)rand.Next(1, 4);
        }
    }

    public class WordSelector : IWordSelector
    {
        private Random _random;
        protected Dictionary<TopicEnum, string[]> _words;

        public WordSelector(Random random)
        {
            _random = random;

            _words = new Dictionary<TopicEnum, string[]>
            {
                { TopicEnum.COUNTRIES, new string[] { "Latvia", "Estonia", "Denmark", "China", "Ireland", "Thailand", "Zimbabwe", "France", "Uganda", "Poland", "Sweden" } },
                { TopicEnum.CITIES, new string[] { "Vilnius", "Kaunas", "Venice", "Kedainiai", "Paris", "Mumbai", "Philadelphia", "Dallas", "Kolkata", "Pasvalys", "Madrid" } },
                { TopicEnum.SEAS, new string[] { "Java", "Solomon", "White", "Sargasso", "Baltic", "Celebes", "labrador", "Norwegian", "Weddell", "Caribbean", "Greenland" } }
            };

        }

        public string SelectWord(TopicEnum? topic)
        {
            if (topic == null) return "";

            return _words[(TopicEnum)topic][_random.Next(_words[(TopicEnum)topic].Length)].ToUpper();
        }
    }

    public class NewWordSelector : WordSelector
    {
        public NewWordSelector(Random random, List<string> moreWords) : base(random)
        {
            var mas = _words[TopicEnum.COUNTRIES];
            var newMas = mas.ToList();
            newMas.AddRange(moreWords);
            _words[TopicEnum.COUNTRIES] = newMas.ToArray();
        }
    }

    public class NewWordSelector_v2_0 : NewWordSelector
    {
        public NewWordSelector_v2_0(Random random, List<string> moreWords) : base(random, moreWords)
        {
        }
    }
}
