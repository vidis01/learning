namespace Learning.Classes
{
    public class A
    {
        private int Age;
        private int Weight { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        private int vidmantoSkaicius = 9;

        private B b;

        public A()
        {

        }

        public A(int age, int weight)
        {
            Random rnd = new Random();
            Age = age;
            Weight = weight;
            b = new(rnd.Next(1, 10));
        }

        public A(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public A(int age, int weight, string name, string lastName, int balas)
        {
            Age = age;
            Weight = weight;
            Name = name;
            LastName = lastName;
            b = new B(balas);
        }

        public void PrintAll()
        {
            Console.WriteLine($"{Name} {LastName} {Age} {Weight} ");
        }

        public void ChangeAge(int age)
        {
            Age = age;
        }

        public void CleanNames()
        {
            Name = string.Empty;
            LastName = string.Empty;
        }

        public string GetName()
        {
            return Name;
        }

        public B GetBElement()
        {
            return b;
        }
    }
}
