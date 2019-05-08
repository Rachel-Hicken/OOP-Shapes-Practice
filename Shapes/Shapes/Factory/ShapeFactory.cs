using System;
using System.Collections.Generic;
using Shapes.Model.Abstract;
using Shapes.Model.Concrete;

namespace Shapes.Factory
{
    internal class ShapeFactory
    {
        private int _randomNumberOfShapes = 0;

        internal Shape CreateShape(ShapeTypes type, int[] dimensions)
        {

            switch (type)
            {
                case ShapeTypes.circle:
                    return new Circle(dimensions);
                case ShapeTypes.square:
                    return new Square(dimensions);
                //case ShapeTypes.triangle:
                //    break;
                //case ShapeTypes.rectangle:
                //    break;
                default:
                    return null;
            }
        }

        internal List<Shape> RandomShapes()
        {
            var shapeFactory = new ShapeFactory();

            var square = shapeFactory.CreateShape(ShapeTypes.square, new[] { 2 });
            //var rectangle = shapeFactory.CreateShape(ShapeTypes.rectangle, new[] { 3, 4 });
            var circle = shapeFactory.CreateShape(ShapeTypes.circle, new[] { 4 });
            //var triangle = shapeFactory.CreateShape(ShapeTypes.triangle, new[] { 2, 4, 3 });
            var shapes = new List<Shape> { square, circle };
            return shapes;
        }

        internal ShapeFactory Create(int numberOfShapes)
        {
            _randomNumberOfShapes = numberOfShapes;
            return this;
        }
    }
}