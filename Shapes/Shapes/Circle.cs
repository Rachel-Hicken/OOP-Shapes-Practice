using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;
        public override double Area => radius * radius * 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }
    }
}
