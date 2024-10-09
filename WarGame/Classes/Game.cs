using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    public class Game : IGame
    {
        private IDeck _deck;
        private List<IPlayer> _players;
        private IRules _rules;

        public Game(IDeck deck, List<IPlayer> players, IRules rules)
        {
            _deck = deck;
            _players = players;
            _rules = rules;
        }

        public void Play()
        {
            DealingCards();
        }
        private void DealingCards()
        {     
            for (int i = 0;  i < 26; i++)
            {
                _players[0].GetCard(_deck.DrawACard());
                _players[1].GetCard(_deck.DrawACard());
            }
        }
    }
}
