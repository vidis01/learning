using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Classes;

namespace WarGame.Interfaces
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public List<ICard> DealtCards { get; set; }
        public List<ICard> WonCards { get; set; }

        public void GetCard(ICard card);
    }
}
