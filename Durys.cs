namespace Learning
{
    public class Durys : IsplestiniaiParametrai
    {
        private string? _medziaga;
        public Durys(float aukstis, float plotis, string pavadinimas, SpalvaEnum spalva, string? medziaga = null) : base(aukstis, plotis, pavadinimas, spalva)
        {
            _medziaga = medziaga;
        }
        public override string GetInfo()
        {
            if (_medziaga != null)
            {
                return $"Durys: {base.GetInfo()}, medžiaga: {_medziaga}.";
            }

            return $"Durys: {base.GetInfo()}.";
        }
    }
}
