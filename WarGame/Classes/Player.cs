using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    public class Player : IPlayer
    {
        public string  Name { get; set; }
        public List<ICard> DealtCards { get; set; }
        public List<ICard> WonCards { get; set; }

        public Player(string name)
        {
            Name = name;
            DealtCards = new List<ICard>();
            WonCards = new List<ICard>();
        }
        public void GetCard(ICard card)
        {
            DealtCards.Add(card);
        }

    }
}
