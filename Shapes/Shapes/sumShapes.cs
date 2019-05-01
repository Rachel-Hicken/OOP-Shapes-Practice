using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class SumShapes
    {
        private double totalSum = 0;
        public SumShapes(double[] shapesList)
        {
            foreach (double s in shapesList)
            {
                totalSum += s;
            }
        }

    }
}
