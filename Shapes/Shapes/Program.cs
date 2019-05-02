using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            var square = new Square(2);
            var square2 = new Square(3);
            var circle = new Circle(4);
            var circle2 = new Circle(1);
            var shapes = new List<Shape> { square, square2, circle, circle2 };
            var areas = shapes.Select(o => { Console.WriteLine(o.Area); return o.Area; }).ToArray();

            Console.WriteLine(new SumShapes(areas).totalSum);
            Console.ReadLine();
        }
    }
}
