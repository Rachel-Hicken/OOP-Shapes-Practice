using Shapes.Model.Abstract;
using Shapes.Model.Concrete;

namespace Shapes.Factory
{
    internal class ShapeFactory
    {
        public ShapeFactory()
        {
        }

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
    }
}