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
            var circle = new Circle(4);
            var squareArea = square.GetArea();
            var circleArea = circle.GetArea();
            //var sumAreas = new SumShapes([squareArea, circleArea]);
            Console.WriteLine(squareArea);
            Console.WriteLine(circleArea);
            //Console.WriteLine(sumAreas);
            Console.ReadLine();
        }
    }
}
