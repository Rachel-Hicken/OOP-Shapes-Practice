using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeLibraryTests
{
    public class ExceptionTest
    {
        public delegate void TestDelegate();

        public static void TestExceptionMessage(string message, TestDelegate method)
        {
            try
            {
                method();
            }
            catch(Exception exc)
            {
                Assert.AreEqual(message, exc.Message);
                throw;
            }
        }
    }
}
