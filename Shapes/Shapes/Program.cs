using System;
using System.Collections.Generic;
using System.Linq;
using Shapes.Factory;
using Shapes.Model.Extensions;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new ShapeFactory().Create(10).RandomShapes();
            shapes.ShowShapes();
        }
    }
}