namespace ShapeLibrary.Model.Abstract
{
    public abstract class Shape : IArea
    {
        protected readonly int[] dimensions;
        public abstract double Area { get; }

        public Shape(int[] sides)
        {
            this.dimensions = sides;
        }
    }
}
