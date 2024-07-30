using Learning.Interfaces;

namespace Learning.Classes
{
    public class Circle : IShape
    {
        public int r;

        public double GetArea()
        {
            return Math.PI * r * r;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
