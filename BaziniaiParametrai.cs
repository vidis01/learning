namespace Learning
{
    public class BaziniaiParametrai
    {
        private string _pavadinimas = "";
        private SpalvaEnum _spalva;
        public BaziniaiParametrai(string pavadinimas, SpalvaEnum spalva)
        {
            _pavadinimas = pavadinimas;
            _spalva = spalva;
        }
        public virtual string GetInfo()
        {
            return $"pavadinimas: {_pavadinimas}, spalva: {_spalva}";
        }
    }
}
