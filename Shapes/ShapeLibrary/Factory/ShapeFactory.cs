using System;
using System.Collections.Generic;
using System.Linq;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Concrete;

namespace ShapeLibrary.Factory
{
    public class ShapeFactory
    {
        private int HowManyShapesToCreate = 0;
        public static Shape CreateShape(ShapeType type, int[] dimensions)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle(dimensions);
                case ShapeType.Square:
                    return new Square(dimensions);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public ShapeFactory Create(int i)
        {
            HowManyShapesToCreate = i;
            return this;
        }


        public List<Shape> RandomShapes()
        {
            const int MAX_DIMENSION_SIZE = 100;
            var maxType = (int)Enum.GetValues(typeof(ShapeType)).Cast<ShapeType>().Max();
            var random = new Random();

            var shapes = new List<Shape>();
            for (int i = 0; i <= HowManyShapesToCreate; i++)
            {
                shapes.Add(ShapeFactory.CreateShape((ShapeType)random.Next(maxType+1),new[]{random.Next(1,MAX_DIMENSION_SIZE)}));
            }

            return shapes;

        }
    }
}