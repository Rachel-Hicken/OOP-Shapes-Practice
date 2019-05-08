using System;

namespace Shapes.Model.Concrete
{
    class Circle : Square
    {
        public override double Area =>base.Area * Math.PI;

        public Circle(int[] radius):base(radius)
        {
        }
    }
}
