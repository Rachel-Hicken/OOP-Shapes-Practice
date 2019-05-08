using Shapes.Factory;
using Shapes.Model.Extension;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new ShapeFactory().Create(10).RandomShapes();
                shapes.ShowShapes();
        }
    }
}
