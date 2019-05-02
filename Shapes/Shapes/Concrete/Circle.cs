using System;

namespace Shapes
{
    class Circle : Square
    {
        public override double Area
        {
            get
            {
                if (_area == 0.0)
                    _area = base.Area*Math.PI;

                return _area;
            }
        }

        public Circle(int[] dimensions) : base(dimensions)
        {
        }
    }
}
