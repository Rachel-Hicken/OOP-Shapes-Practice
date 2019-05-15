using ShapeLibrary.Model.Abstract;
using System;

namespace ShapeLibrary.Model.Concrete
{
    public class Square : Shape
    {
        //public override double Area => Math.Pow(dimensions[0], 2);
        public override double Area => dimensions[0] * dimensions[0];

        public Square(int[] sides) : base(sides)
        {
        }
    }
}
