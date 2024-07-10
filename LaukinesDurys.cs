namespace Learning
{
    public class LaukinesDurys : Durys
    {
        private bool _akute;
        private int _spynuSkaicius;
        public LaukinesDurys(bool akute, int spynuSkaicius, float aukstis, float plotis, string pavadinimas, SpalvaEnum spalva, string? medziaga = null) : base(aukstis, plotis, pavadinimas, spalva, medziaga)
        {
            _akute = akute;
            _spynuSkaicius = spynuSkaicius;
        }
    }
}
