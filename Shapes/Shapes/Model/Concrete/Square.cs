using Shapes.Model.Abstract;
using System;

namespace Shapes.Model.Concrete
{
    class Square : Shape
    {
        public override double Area => Math.Pow(dimensions[0], 2);

        public Square(int[] sides) : base(sides)
        {
        }
    }
}
