using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Model.Concrete.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void CalculateSquareAreaTest()
        {
            var side = 2;
            var expected = Math.Pow(side, 2);
            var actual = new Square(new[] { side }).Area;
            Assert.AreEqual(expected, actual);
        }
    }
}