using System;
using System.Linq;

namespace ShapeLibrary.Model.Abstract
{
    public abstract class Shape:IArea
    {
        protected readonly int[] dimensions;
        public abstract double Area { get; }

        protected Shape(int[] dimensions)
        {
            if (dimensions == null || !(dimensions.Length > 0) || dimensions.Where(o =>(o == null || o == 0.0)).Any())
                throw new Exception("A shape must have at least one dimension");

            this.dimensions = dimensions;
        }
    }
}
