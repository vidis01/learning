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
            
            for (int i = 1; i <= 26; i++)
            {
                List<ICard> roundCards = new();
                foreach (var player in _players)
                {
                    roundCards.Add(player.PlayACard());
                }
                int result = _rules.DecideRoundWinner(roundCards);
                if (result != -1)
                {
                    _players[result].TakeWonCards(roundCards);
                }
            }

            List<int> totalPoints = new();
            var highestPoints = 0;
            foreach (var player in _players)
            {
                totalPoints.Add(player.CountTotalPoints());
            }

            highestPoints = totalPoints.Max();

            for (int i = 0; i < totalPoints.Count(); i++)
            {
                if (totalPoints[i] == highestPoints)
                {
                    Console.WriteLine($"Winner is {_players[i].Name}, total points: {totalPoints[i]}");
                }
            }
            Console.WriteLine("-----------");
        }


        private void DealingCards()
        {     
            for (int i = 0; i < 26; i++)
            {
                _players[0].GetCard(_deck.DrawACard());
                _players[1].GetCard(_deck.DrawACard());
            }
        }
    }
}
