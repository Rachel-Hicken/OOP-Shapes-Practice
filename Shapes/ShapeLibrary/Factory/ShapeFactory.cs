using System;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Concrete;

namespace ShapeLibrary.Factory
{
    public abstract class ShapeFactory
    {
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
    }
}