using ShapeLibrary.Factory;
using ShapeLibrary.Model.Extensions;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new RandomShapeFactory().Create(10).Random().ToIArea();
            shapes.ShowShapes();
        }
    }
}

//TODO:
// 0. break into it's own assembly [DONE]
// 1. make main look like above [DONE]
// 2. display results in a web app  (extensions and referencing using different lib to get different behavior [DONE]
//        2a. do we need a class library [DONE]
//        2b. create unit test to test library [DONE]
// 3. teach entity framework [DONE]
// 4. answer question that Rachel may have [DONE]
// 5. template pattern
// Lastly - on your own: review SOLID principles

//    ----------------------------
//To Do For Monday (message daily updates and roadblock questions):
//1. Get randomizer to work [DONE]
//2. Show shape type and area on show display (web and console, see images) [DONE]
//3. Create unit test to public classes and methods library
//    a. edge case: when pass in number for random result get same number back 
//    b. randomizer is actually random (done)
//    c. Unit tests
//        1. check that exception is thrown when _numberRandomShapes is not set 
//        2. check that the exception that is thrown is my custom exception type (which I will call ShapeFactoryException)
//        3. validate that the message in the exception thrown in number 2 is this: "You must specify the number of random shapes you want to generate"
