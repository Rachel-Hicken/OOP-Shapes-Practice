using System;

namespace ShapeLibrary.Model.Concrete
{
    public class Circle : Square
    {
        public override double Area =>base.Area * Math.PI;

        public Circle(int[] radius):base(radius)
        {
        }
    }
}
