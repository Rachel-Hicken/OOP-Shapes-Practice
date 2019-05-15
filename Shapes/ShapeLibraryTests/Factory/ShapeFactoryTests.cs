using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;
using ShapeLibraryTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShapeLibrary.Factory.ShapeFactory;

namespace ShapeLibrary.Factory.Tests
{
    [TestClass()]
    public class ShapeFactoryTests
    {
        [TestMethod()]
        public void RandomShapesTest()
        {
            var expected = 100;
            var shapes = new ShapeFactory().Create(expected).RandomShapes();
            var currentShape = "";
            var lastShape = currentShape;
            var firstShapeName = shapes.First().ToString();
            var otherShapes = shapes.Where(shape => shape.ToString() != firstShapeName).ToList();
            Assert.IsTrue(otherShapes.Any(), $"All shapes are {firstShapeName}");

        }

        [TestMethod()]
        [ExpectedException(typeof(ShapeFactoryException), "")]
        public void ExceptionRandomShapesTest()
        {
            //NewMethod("You must specify the number of random shapes you want to generate");
            ExceptionTest.TestExceptionMessage("You must specify the number of random shapes you want to generate", NewMethod);
        }

        //private static void NewMethod(string message)
        private static void NewMethod()
        {
            //try
            //{
                var shapes = new ShapeFactory().Create(0);
            //}
            //catch(Exception exc)
            //{
            //    Assert.IsTrue(exc.Message == message, $"Expected: \"{message}\", but got: \"{exc.Message}\"");
            //    throw;
            //}
        }

        [TestMethod()]
        public void ZeroRandomShapesTest()
        {
            var shapes = new ShapeFactory().RandomShapes();
            Assert.IsFalse(shapes.Any());
        }

        [TestMethod()]
        public void CreateTest()
        {
            var expected = 5;
            var shapes = new ShapeFactory().Create(expected).RandomShapes();
            Assert.IsNotNull(shapes);
            Assert.AreEqual(expected, shapes.Count());
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
            foreach (var shape in shapes)
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