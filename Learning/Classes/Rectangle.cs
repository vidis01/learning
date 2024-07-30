using Learning.Interfaces;

namespace Learning.Classes
{
    public class Rectangle : IShape
    {
        public int x, y;

        public double GetArea()
        {
            return x * y;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
