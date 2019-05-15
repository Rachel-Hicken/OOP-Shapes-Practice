using System;
using System.Collections.Generic;
using System.Linq;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Concrete;

namespace ShapeLibrary.Factory
{
    public partial class ShapeFactory
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

        public List<Shape> RandomShapes(int maxDimensionLength = 2)
        {
            var shapes = new List<Shape>();
            var shapeFactory = new ShapeFactory();
            var randomDimensionLength = new Random();
            Shape shape;

            var shapeTypeEnumValues = Enum.GetValues(typeof(ShapeTypes));
            var random = new Random();

            for (var i=0; i<_randomNumberOfShapes; i++)
            {
                shape = shapeFactory.CreateShape((ShapeTypes)shapeTypeEnumValues.GetValue(random.Next(shapeTypeEnumValues.Length)), new[] { randomDimensionLength.Next(1, maxDimensionLength + 1) });
                shapes.Add(shape);
            }
            return shapes;
        }
    

        public ShapeFactory Create(int numberOfShapes)
        {
            _randomNumberOfShapes = numberOfShapes;
            if(!(_randomNumberOfShapes > 0))
            {
                throw new ShapeFactoryException("You must specify the number of random shapes you want to generate");
            }
            
            return this;
        }
    }
}