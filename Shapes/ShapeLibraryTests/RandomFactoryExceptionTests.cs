using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;

namespace ShapeLibraryTests
{
    [TestClass]
    public class RandomFactoryExceptionTests
    {
              
        public void TestRandomFactoryRadomReturnsNullWhenCreateZero()
        {
            var shapes = new RandomShapeFactory().Create(0).Random();
        }

        public void TestRandomFactoryRadomReturnsNullWhenOnlyCallRandom()
        {
            var shapes = new RandomShapeFactory().Random();
        }

        [TestMethod]
        [ExpectedException(typeof(ShapeFactoryException), "")]
        public void RandomFactoryRadomReturnsNullWhenCreateZeroTest()
        {
            ExceptionTest.Exception<ShapeFactoryException>("You much specify how many shapes you want to create.",
                TestRandomFactoryRadomReturnsNullWhenCreateZero);
        }

        [TestMethod]
        [ExpectedException(typeof(ShapeFactoryException), "")]
        public void RandomFactoryRadomReturnsNullWhenOnlyCallRandomTest()
        {
            ExceptionTest.Exception<ShapeFactoryException>("You much specify how many shapes you want to create.",
                TestRandomFactoryRadomReturnsNullWhenOnlyCallRandom);
        }
    }
}
