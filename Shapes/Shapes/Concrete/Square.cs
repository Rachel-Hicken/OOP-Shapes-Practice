using System;

namespace Shapes
{
    public class Square : Shape
    {
        protected double _area;
        public override double Area
        {
            get
            {
                if (_area == 0.0)
                    _area = Math.Pow(dimensions[0], 2);

                return _area;
            }
        }
        
        public Square(int[] dimensions) : base(dimensions)
        {
        }
    }
}
