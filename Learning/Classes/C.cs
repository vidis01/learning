namespace Learning.Classes
{
    public class C : A
    {
        private int Height;
        public C(int height, int age, int weight, string name, string lastName, int balas) : base(age, weight, name, lastName, balas)
        {
            Height = height;
        }

        public void PrintAll(bool a)
        {
            PrintAll();
            Console.Write(Height);
            Console.WriteLine();
        }
    }
}
