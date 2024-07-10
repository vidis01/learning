using System.Text;

namespace Learning
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var namas = new Namas(13, "Žemaitės g.", "Vilnius");

            namas.IdetiLaukinesDuris(new LaukinesDurys(true, 3, 2.5f, 1.5f, "Algio", SpalvaEnum.MĖLYNA));

            foreach (var laukinesDurys in namas.LaukinesDurys)
            {
                Console.WriteLine(laukinesDurys.GetInfo());
            }

        }
    }
}
