using Learning.Enums;

namespace Learning.Classes
{
    public class Symbol
    {
        public int Count { get; set; }
        public List<SymbolTypeEnum> SymbolIndications { get; set; }

        public Symbol()
        {
            SymbolIndications = new();
            Count = 1;
        }
    }
}
