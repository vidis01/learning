

using WarGame.Enums;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    public class Card : ICard
    {
        public KindEnum Kind { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int CardRank {  get; set; }

        public Card(KindEnum kind, string name, int value, int cardRank)
        {
            Kind = kind;
            Name = name;
            Value = value;
            CardRank = cardRank;
        }
    }
}
