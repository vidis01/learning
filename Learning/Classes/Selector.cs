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
}
