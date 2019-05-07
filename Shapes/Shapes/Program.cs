using ShapeLibrary.Factory;
using ShapeLibrary.Model.Extensions;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new ShapeFactory().Create(10).RandomShapes();
            shapes.ShowShapes();
        }
    }
}

//TODO:
// 0. break into it's own assembly
// 1. make main look like above
// 2. display results in a web appn  (extensions and referencing using different lib to get different behavior
//        2a. do we need a class library
// 3. teach entity framework
// 4. answer question that Rachel may have
// 5. teach template pattern
// Lastly - on your own: review SOLID principles