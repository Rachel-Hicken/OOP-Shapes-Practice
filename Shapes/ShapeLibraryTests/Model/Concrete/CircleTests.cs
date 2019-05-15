using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Factory;
using ShapeLibrary.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Model.Concrete.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateCircleAreaTest()
        {
            var radius = 2;
            var expected = radius * radius * Math.PI;
            var actual = new Circle(new[] { radius }).Area;
            Assert.AreEqual(expected, actual);
        }
    }
}