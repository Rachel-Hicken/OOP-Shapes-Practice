using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;
using ShapeLibrary.Model.Abstract;

namespace ShapeLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
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

        [TestMethod]
        public void RandomFactoryConfirmRandomTest()
        {
            int expectedValue = 10;
            var shapes = new RandomShapeFactory().Create(10).Random().Select(o=>o as Shape);
            var firstType = shapes.First().ToString();
            var different = shapes.Where(o => o.ToString() != firstType).ToList();
            Assert.IsTrue(different.Any());
        }
    }
}
