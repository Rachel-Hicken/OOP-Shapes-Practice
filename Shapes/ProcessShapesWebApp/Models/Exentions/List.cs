using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShapeLibrary.Model.Abstract;
using ShapeLibrary.Model.Extensions;

namespace ProcessShapesWebApp.Models.Extensions
{
    public static class List
    {
        internal static string ShowAreas<T>(this List<T> list) where T : IArea
        {
            var builder = new StringBuilder();
            list.Select(o => { builder.Append($"{o.ToString().GetLastString('.')}'s area:  {o.Area} <br/>");return o.Area;}).ToList();
            return builder.ToString();
        }

        public static string ShowShapes<T>(this List<T> shapes)where T : IArea
        {
            var builder = new StringBuilder(shapes.ShowAreas());
            
            builder.Append("<hr>");
            builder.Append($"Sum of Shape Areas: {shapes.SumAreaArray()} <br/>");
            return builder.ToString();

        }
    }
}