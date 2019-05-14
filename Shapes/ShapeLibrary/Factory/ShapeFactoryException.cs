using System;

namespace ShapeLibrary.Factory
{
    public partial class ShapeFactory
    {
        public class ShapeFactoryException : Exception
        {
            public ShapeFactoryException(string message) : base(message) { }
        }
    }
}