using System;
using System.Collections.Generic;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Concrete;

namespace ShapeLibrary.Factory
{
    public class ShapeFactory
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

        public List<Shape> RandomShapes(int maxLength = 200)
        {
            var shapes = new List<Shape>();
            var shapeFactory = new ShapeFactory();
            var randomDimension = new Random(maxLength);
            Shape shape;

            var values = Enum.GetValues(typeof(ShapeTypes));
            var random = new Random();

            for (var i=0; i<_randomNumberOfShapes; i++)
            {
                ShapeTypes randomBar = (ShapeTypes)values.GetValue(random.Next(values.Length));
                shape = shapeFactory.CreateShape(randomBar, new[] { randomDimension.Next() });
                shapes.Add(shape);
            }
            return shapes;
        }
    

        public ShapeFactory Create(int numberOfShapes)
        {
            _randomNumberOfShapes = numberOfShapes;
            return this;
        }
    }
}