

using WarGame.Enum;

namespace WarGame.Classes
{
    internal class Card
    {
        public KindEnum Kind { get; private set; }
        public string Name { get; private set; }
        public int Value { get; private set; }

        public Card(KindEnum kind, string name, int value)
        {
            kind = Kind;
            name = Name;
            value = Value; 
        }
    }
}
