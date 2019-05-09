using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;

namespace ShapeLibraryTests
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void RandomFactoryRadomReturnsAnObjectTest()
        {
            var shapes = new RandomShapeFactory().Create(1).Random();
            Assert.IsNotNull(shapes);
        }
        [TestMethod]
        public void RandomFactoryCreateTest()
        {
            int expectedValue = 10;
            var shapes = new RandomShapeFactory().Create(10).Random();
            Assert.IsNotNull(shapes);
            Assert.AreEqual(expectedValue,shapes.Count);
        }
    }
}
