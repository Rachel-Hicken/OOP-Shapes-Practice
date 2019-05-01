using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        private double side;

        public Square(int side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}
