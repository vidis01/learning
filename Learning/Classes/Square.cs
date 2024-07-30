using Learning.Interfaces;

namespace Learning.Classes
{
    public class Square : IShape
    {
        public int x;

        public double GetArea()
        {
            return x * x;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
