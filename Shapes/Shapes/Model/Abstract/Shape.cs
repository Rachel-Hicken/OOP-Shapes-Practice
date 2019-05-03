using System;

namespace Shapes.Model.Abstract
{
    public abstract class Shape:IArea
    {
        protected int[] dimensions;
        public abstract double Area { get; }

        protected Shape(int[] dimensions)
        {
            if (dimensions==null || !(dimensions.Length > 0))
                throw new Exception("A shape must have at least one dimension");

            this.dimensions = dimensions;
        }
    }
}
