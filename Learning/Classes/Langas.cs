using Learning.Enums;

namespace Learning.Classes
{
    public class Langas : IsplestiniaiParametrai
    {
        private int _stikluSkaicius;
        public Langas(int stikluSkaicius, float aukstis, float plotis, string pavadinimas, SpalvaEnum spalva) : base(aukstis, plotis, pavadinimas, spalva)
        {
            _stikluSkaicius = stikluSkaicius;
        }

        public override string GetInfo()
        {
            return $"Langas: {base.GetInfo()}, stiklų skaičius: {_stikluSkaicius}.";
        }
    }
}
