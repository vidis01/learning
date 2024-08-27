using Learning.Interfaces;

namespace Learning.AbstractClasses
{
    public class MyClass : BaseClassA
    {
        public MyClass(int a) : base(a)
        {
        }

        public override void Method()
        {
            Console.WriteLine(_myProperty);
        }
    }

    public class MyClass2 : MyClass, IPrototype
    {
        public MyClass2(int a) : base(a)
        {
        }

        //pavyzdys, kad MyClass2 metoda implementuoja jau kitaip nei MyClass
        public override void Method()
        {
            Console.WriteLine(nameof(_myProperty));
        }
    }
}
