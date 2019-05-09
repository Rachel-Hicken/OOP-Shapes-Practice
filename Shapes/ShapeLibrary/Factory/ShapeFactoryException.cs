using System;

namespace ShapeLibrary.Factory
{
    public class ShapeFactoryException : Exception
    {
        public ShapeFactoryException(string message):base(message)
        {
        }
    }
}