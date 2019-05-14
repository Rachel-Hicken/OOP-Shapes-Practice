using ShapeLibrary.Model.Abstract;
using System;

namespace ShapeLibrary.Model.Concrete
{
    class Square : Shape
    {
        public override double Area => Math.Pow(dimensions[0], 2);

        public Square(int[] sides) : base(sides)
        {
        }
    }
}
