using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Interfaces
{
    public interface IDeck
    {
        public List<ICard> DeckOfCards { get; set; }
        public ICard DrawACard();

    }
}
