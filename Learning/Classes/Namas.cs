using Learning.Enums;

namespace Learning.Classes
{
    public class Namas
    {
        private int _namoNumeris;
        private string _gatvesPavadinimas = "";
        private string _gyvenviet4sPavadinimas = "";
        public List<LaukinesDurys> LaukinesDurys { get; private set; }
        public Dictionary<KambarysEnum, List<Kambarys>> Kambariai { get; private set; }

        public Namas(int namoNumeris, string gatvesPavadinimas, string gyvenviet4sPavadinimas)
        {
            Kambariai = new Dictionary<KambarysEnum, List<Kambarys>>();
            LaukinesDurys = new List<LaukinesDurys>();
            _namoNumeris = namoNumeris;
            _gatvesPavadinimas = gatvesPavadinimas;
            _gyvenviet4sPavadinimas = gyvenviet4sPavadinimas;
        }

        public void IdetiLaukinesDuris(LaukinesDurys laukinesDurys)
        {
            LaukinesDurys.Add(laukinesDurys);
        }

        public void IdetiKambari(KambarysEnum kambarioTipas, Kambarys kambarys)
        {
            var kambarysExist = Kambariai.TryGetValue(kambarioTipas, out var kambariai);

            if (kambarysExist)
            {
                if (kambariai != null)
                {
                    kambariai.Add(kambarys);
                }
                else
                {
                    Kambariai[kambarioTipas] = new List<Kambarys> { kambarys };
                }
            }
            else
            {
                Kambariai.Add(kambarioTipas, new List<Kambarys> { kambarys });
            }
        }
    }
}
