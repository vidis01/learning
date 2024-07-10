namespace Learning
{
    public class Kambarys
    {
        private float _plotas;
        private List<Langas> _langai;
        private List<Durys> _durys;
        public Kambarys(float plotas)
        {
            _plotas = plotas;
            _langai = new List<Langas>();
            _durys = new List<Durys>();
        }

        public void IdetiLanga(Langas langas)
        {
            _langai.Add(langas);
        }

        public void IdetiDuris(Durys durys)
        {
            _durys.Add(durys);
        }

        public void GetLangaiInfo()
        {
            Console.WriteLine("Langai:");
            foreach (var langas in _langai)
            {
                Console.WriteLine(langas.GetInfo());
            }
            Console.WriteLine("-----------");
        }

        public void GetDurysInfo()
        {
            Console.WriteLine("Durys:");
            foreach (var durys in _durys)
            {
                Console.WriteLine(durys.GetInfo());
            }
            Console.WriteLine("-----------");
        }
    }
}
