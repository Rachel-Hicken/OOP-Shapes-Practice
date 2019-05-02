using System;

namespace Shapes
{
    internal class ShapeFactory
    {
        public static IArea CreateShape(ShapeType type, int[] dimensions)
        {
            switch (type)
            {
                case ShapeType.Triangle:
                    return null;
                case ShapeType.Circle:
                    return new Circle(dimensions);
                case ShapeType.Square:
                    return new Square(dimensions);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}