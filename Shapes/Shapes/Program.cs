using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            var shapes = new List<IArea>{ShapeFactory.CreateShape(ShapeType.Square,new[]{2}),ShapeFactory.CreateShape(ShapeType.Circle,new[]{4})};
            Console.WriteLine(shapes.Select(o => { Console.WriteLine(o.Area);return o.Area;}).ToArray().Sum());
            Console.ReadLine();
        }
    }
}
///TODO:
/// GetShape(enum,array or ints);
/// ListOfShapes.AreaSum
/// ListOfShapes IAreaSum and Shapes IArea
/// use getters and interfaces
