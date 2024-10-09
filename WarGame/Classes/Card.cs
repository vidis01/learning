

using WarGame.Enums;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    internal class Card : ICard
    {
        public KindEnum Kind { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public Card(KindEnum kind, string name, int value)
        {
            Kind = kind;
            Name = name;
            Value = value; 
        }
    }
}
