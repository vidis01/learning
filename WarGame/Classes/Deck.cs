using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Enums;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    public class Deck : IDeck
    {
        public List<ICard> DeckOfCards { get; set; }
        private Random _random;
        public Deck()
        {
            DeckOfCards = new();
            _random = new();
            InitializeCards();
        }
        private void InitializeCards()
        {
            foreach (var item in Enum.GetValues<KindEnum>())
            {
                int i = 2;
                for (i = 2; i <= 10; i++)
                {
                    DeckOfCards.Add(new Card(item, $"{i}", i, i));
                }
                DeckOfCards.Add(new Card(item, "J", 10, i));
                DeckOfCards.Add(new Card(item, "Q", 10, ++i));
                DeckOfCards.Add(new Card(item, "K", 10, ++i));
                DeckOfCards.Add(new Card(item, "A", 10, ++i));
            }
        }
        public ICard DrawACard()
        {
            var card = DeckOfCards[_random.Next(0, DeckOfCards.Count)];
            DeckOfCards.Remove(card);
            return card;
        }
    }

}
