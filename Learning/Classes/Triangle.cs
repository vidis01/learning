using Learning.Interfaces;

namespace Learning.Classes
{
    public class Triangle : IShape, ITest
    {
        public int x, y;

        public string Name { get; set; } = "";

        public double GetArea()
        {
            return x * y / 2;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
