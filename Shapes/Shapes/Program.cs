using System;
using System.Collections.Generic;
using System.Linq;
using Shapes.Extensions;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            var square = ShapeFactory.CreateShape(ShapeType.Square, new[] {2});
            Console.WriteLine(square.Area);
            var circle = ShapeFactory.CreateShape(ShapeType.Square, new[] {2});
            Console.WriteLine(circle.Area);

//            var shapes2= new List<IArea>{ShapeFactory.CreateShape(ShapeType.Square,new[]{2}),ShapeFactory.CreateShape(ShapeType.Circle,new[]{4})};
          //  var shapes = new ShapeFactory().Create(10).RandomShapes();
//            shapes.ShowAreas();
//            Console.WriteLine(shapes.SumAreaArray());

            Console.ReadLine();
        }
    }
}
///TODO:
/// GetShape(enum,array or ints);
/// ListOfShapes.AreaSum
/// ListOfShapes IAreaSum and Shapes IArea
/// use getters and interfaces
