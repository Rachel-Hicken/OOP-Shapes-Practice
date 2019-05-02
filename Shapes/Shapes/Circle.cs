namespace Shapes
{
    class Circle : Shape
    {
        private readonly double radius;
        public override double Area => radius * radius * 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }
    }
}
