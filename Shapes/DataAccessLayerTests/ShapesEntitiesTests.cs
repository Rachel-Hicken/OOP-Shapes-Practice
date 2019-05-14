using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;
using ShapeLibrary.Model.Concrete;
using System;
using System.Linq;

namespace DataAccessLayer.Tests
{
    [TestClass()]
    public class ShapesEntitiesTests
    {
        [TestMethod()]
        public void ShapesEntitiesTest()
        {
            var context = new ShapesEntities();
            Assert.IsNotNull(context);
            Assert.IsNotNull(context.vwShapes);
            Assert.IsTrue(context.vwShapes.Any());
            Assert.AreEqual(3, context.vwShapes.Count());
        }

        [TestMethod()]
        public void ShapesEntitiesCheckValueTest()
        {
            var context = new ShapesEntities();
            Assert.IsNotNull(context);
            //Assert.AreEqual("Square1", context.vwShapes.Select(o => o).Where(o => o.Id == 1).First().Name);
            Assert.AreEqual("Circle1", context.vwShapes.First(o => o.Id == 2).Name);
        }

        [TestMethod()]
        public void CalculateCircleAreaTest()
        {
            var radius = 2;
            var expected = radius * radius * Math.PI;
            var actual = new Circle(new[] { radius }).Area;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateSquareAreaTest()
        {
            var side = 2;
            var expected = Math.Pow(side, 2);
            var actual = new Square(new[] { side }).Area;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShapeFactoryTest()
        {
            var length = 1;
            var circleArea = Math.Pow(length, 2) * Math.PI;
            var squareArea = Math.Pow(length, 2);
            double expectedShapeArea = 0;
            var myFactory = new ShapeFactory();
            var shapes = myFactory.Create(2).RandomShapes(length);
            foreach(var shape in shapes)
            {
                switch (shape.ToString())
                {
                    case "ShapeLibrary.Model.Concrete.Circle":
                        expectedShapeArea = circleArea;
                        break;
                    case "ShapeLibrary.Model.Concrete.Square":
                        expectedShapeArea = squareArea;
                        break;
                }
                Assert.AreEqual(expectedShapeArea, shape.Area);
            }
        }
    }
}