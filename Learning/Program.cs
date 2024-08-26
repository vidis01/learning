using Learning.Classes;
using Learning.Interfaces;
using System.Text;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<IShape> shapes = new List<IShape> { 
                new Circle { r = 3 }, 
                new Rectangle { x = 3, y = 5 }, 
                new Square { x = 7 }, 
                new Triangle { x = 2, y = 10, Name = "naujas" } };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());

                if (shape is ITest)
                {
                    Console.WriteLine(((ITest)shape).Name);
                }
            }
        }
    }
}
