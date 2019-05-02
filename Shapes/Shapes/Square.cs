namespace Shapes
{
    public class Square : Shape
    {
        private readonly double side;
        public override double Area => side * side;

        public Square(int side)
        {
            this.side = side;
        }

    }
}
