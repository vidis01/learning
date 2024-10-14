using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Interfaces;

namespace WarGame.Classes
{
    public class Rules : IRules
    {
        public int DecideRoundWinner(List<ICard> playingCards)      
        {     
            int maxCardRank = playingCards.Max(c => c.CardRank);
            var selectedCards = playingCards.Where(c => c.CardRank == maxCardRank);
            if (selectedCards.Count() > 1)
            {
                //dumps all cards
                return -1;
            }
            else
            {
                //announce a winner

                var winner = playingCards.FindIndex(a => a.CardRank == maxCardRank);

                return winner;
            }
        }
    }
}
