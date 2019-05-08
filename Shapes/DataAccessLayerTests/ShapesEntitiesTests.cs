using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataAccessLayer.Tests
{
    [TestClass()]
    public class ShapesEntitiesTests
    {
        [TestMethod()]
        public void ShapesEntitiesHasDataTest()
        {

            var context = new ShapesEntities();
            Assert.IsNotNull(context);
            Assert.IsTrue(context.vwShapes.Any());
            Assert.AreEqual(3,context.vwShapes.Count());
        }

        [TestMethod()]
        public void ShapesEntitiesChackValuesTest()
        {

            var context = new ShapesEntities();
            Assert.IsNotNull(context);
            Assert.AreEqual("Square1",context.vwShapes.First(o=>o.Id==1).Name);

        }

    }
}