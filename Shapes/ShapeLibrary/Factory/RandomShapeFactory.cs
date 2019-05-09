using System;
using System.Collections.Generic;
using System.Linq;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Concrete;
using ShapeLibrary.Model.Extensions;

namespace ShapeLibrary.Factory
{
    public class RandomShapeFactory:RandomFactory
    {
        protected override IList<object> CreateRandom(int count)
        {
            var maxType = (int)Enum.GetValues(typeof(ShapeType)).Cast<ShapeType>().Max();
            var random = new Random();

            var shapes = new List<Shape>();
            for (int i = 0; i <= count; i++)
            {
                shapes.Add(ShapeFactory.CreateShape((ShapeType)random.Next(maxType+1),new[]{random.Next(1,MAX_DIMENSION_SIZE)}));
            }

            return shapes.Select(o=>o as object).ToList();
        }
    }
}
