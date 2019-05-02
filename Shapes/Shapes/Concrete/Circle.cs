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
//                _area = Math.Pow(dimensions[0],2)*Math.PI;
                return _area;
            }
        }

        public Circle(int[] dimensions) : base(dimensions)
        {
        }
    }
}
