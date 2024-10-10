using System.Collections.Generic;
using WarGame.Classes;
using WarGame.Enums;
using WarGame.Interfaces;

namespace Tests.WarGame
{
    public class RulesTests
    {
        [Fact]
        public void TestDecideRoundWinner()
        {
            var rules = new Rules();
            List<ICard> cards = new List<ICard> {new Card(KindEnum.DIAMOND, "7", 7, 7), new Card(KindEnum.SPADE, "5", 5, 5), new Card(KindEnum.SPADE, "9", 9, 9), new Card(KindEnum.SPADE, "A", 10, 13) };
            int result = rules.DecideRoundWinner(cards);
            Assert.Equal(3, result);
        }
    }
}   