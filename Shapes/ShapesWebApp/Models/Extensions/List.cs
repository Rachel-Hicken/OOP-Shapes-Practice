using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesWebApp.Models.Extensions
{
    public static class List
    {
        public static string ShowShapes<T>(this IList<T> list) where T : IArea
        {
            var result = new StringBuilder();
            list.Select(o => { result.Append($"This {o.GetType().Name}'s area is {o.Area} <br/>"); return o; }).ToArray();

            result.Append("<hr>");
            result.Append($"Sum of Shape Areas: {list.SumAreaArray().ToString()} <br/>");
            return result.ToString();
        }
    }
}