using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeLibraryTests
{
    public class ExceptionTest
    {
        public delegate void TestDelegate();
        public static void Exception<T>(string message, TestDelegate theMethod) where T : Exception
        {
            try
            {
                theMethod();
            }
            catch (T exc)
            {
                Assert.AreEqual(message, exc.Message);
                throw;
            }
        }

        public object CallTheMethod(Delegate theMethod, params object[] parameters)
        {
            return theMethod.DynamicInvoke(parameters);
        }
    }
}