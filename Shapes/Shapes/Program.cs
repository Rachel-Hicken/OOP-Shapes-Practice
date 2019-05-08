using Shapes.Factory;
using Shapes.Model.Abstract;
using Shapes.Model.Concrete;
using Shapes.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var square = shapeFactory.CreateShape(ShapeTypes.square, new[] { 2 });
            //var rectangle = shapeFactory.CreateShape(ShapeTypes.rectangle, new[] { 3, 4 });
            var circle = shapeFactory.CreateShape(ShapeTypes.circle, new[] { 4 });
            //var triangle = shapeFactory.CreateShape(ShapeTypes.triangle, new[] { 2, 4, 3 });
            var shapes = new List<IArea> { square, circle };
            Console.WriteLine(shapes.SumAreaArray());
            Console.ReadLine();
        }
    }
}
