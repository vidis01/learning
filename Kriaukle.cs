namespace Learning
{
    public class Kriaukle : BaziniaiParametrai
    {
        private double _skersmuo;
        public Kriaukle(double skersmuo, string pavadinimas, SpalvaEnum spalva) : base(pavadinimas, spalva)
        {
            _skersmuo = skersmuo;
        }
        public override string GetInfo()
        {
            return $"Kriauklė: {base.GetInfo()}, skersmuo: {_skersmuo}.";
        }
    }
}
