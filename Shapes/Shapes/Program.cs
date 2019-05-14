using ShapeLibrary.Factory;
using ShapeLibrary.Model.Extension;

namespace ShapeLibrary
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
