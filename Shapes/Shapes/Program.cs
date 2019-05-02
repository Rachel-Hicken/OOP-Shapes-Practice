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
//
//            var square = new Square(2);
//            var circle = new Circle(4);
//            Console.WriteLine(square.Area);
//            Console.WriteLine(circle.Area);
//            Console.WriteLine(new SumShapes(new[]{square.Area,circle.Area}).totalSum);

//            var shapes = new List<IArea>{new Square(2),new Circle(4)};
//            var areas = shapes.Select(o =>{Console.WriteLine(o.Area);return o.Area;}).ToArray();
//            Console.WriteLine(new SumShapes(areas).totalSum);
//            Console.ReadLine();


            var shapes = new List<IArea>{new Square(2),new Circle(4)};
            Console.WriteLine(new SumShapes(shapes.Select(o => { Console.WriteLine(o.Area);return o.Area;}).ToArray()).totalSum);
            Console.ReadLine();
        }
    }
}
///TODO:
/// GetShape(enum,array or ints);
/// ListOfShapes.AreaSum
/// ListOfShapes IAreaSum and Shapes IArea
/// use getters and interfaces
