using System;
using Shapes.Model.Abstract;

namespace Shapes.Model.Concrete
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
        
        public Square(int[] dimensions) : base(dimensions){}
    }
}
