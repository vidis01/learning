using Learning.Enums;

namespace Learning.Classes
{
    public class IsplestiniaiParametrai : BaziniaiParametrai
    {
        private float _aukstis;
        private float _plotis;
        public IsplestiniaiParametrai(float aukstis, float plotis, string pavadinimas, SpalvaEnum spalva) : base(pavadinimas, spalva)
        {
            _aukstis = aukstis;
            _plotis = plotis;
        }
    }
}
