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
            int howManyCardsToDeal = _deck.DeckOfCards.Count / _players.Count;

            DealingCards();

            int playerIndex = 0;
            for (int i = 1; i <= howManyCardsToDeal; i++)
            {
                playerIndex = 0;
                List<ICard> roundCards = new();
                Console.WriteLine($"Round {i}: ");

                foreach (var player in _players)
                {
                    roundCards.Add(player.PlayACard());
                    Console.WriteLine($"{player.Name}'s card: {roundCards[playerIndex].Name} of {roundCards[playerIndex].Kind}");
                    playerIndex++;
                }

                int result = _rules.DecideRoundWinner(roundCards);

                if (result != -1)
                {
                    Console.WriteLine($"{_players[result].Name}'s won this round!\n");
                    _players[result].TakeWonCards(roundCards);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("It's a tie!\n");
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
