namespace Shapes
{
    class Square : Shape
    {
        private double side;
        public override double Area => side * side;

        public Square(int side)
        {
            this.side = side;
        }
    }
}
