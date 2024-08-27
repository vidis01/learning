using Learning.Interfaces;

namespace Learning.AbstractClasses
{
    public abstract class BaseClassA : IName
    {
        protected int _myProperty;

        public string Name { get; } = "abstarkcios klase name";
        string IName.Name { get; } = "interfeiso name";

        //nors abstrakcios klase objekto sukurti negalima, bet konstruktoriu jinai turi
        //konstruktorius reikalingas tam, kad butu galima per ji inicializuoti abstrakcios klases propercius,
        //jeigu to reikia.
        //abstarkti klase jeigu ir nera aprasytas konstruktorius, jinai vistiek turi be parametri defoultini konstruktoriu
        //kaip ir visos paprastos klases.
        //Tai yra labai svarbi info, nes 90 proc. uzduodamas koks nors susijes klausimas apie abstarkcias klases.
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
        protected BaseClassA(int myProperty)
        {
            _myProperty = myProperty;
        }

        public abstract void Method();

        public string GetName()
        {
            return nameof(BaseClassA);
        }

        public string PrintName()
        {
            throw new NotImplementedException();
        }
    }
}
