using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Enums;

namespace WarGame.Interfaces
{
    public interface ICard
    {
        public KindEnum Kind { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
