using ShapeLibrary.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLibrary.Model.Extension
{
    public static class List
    {
        internal static double[] ToAreaArray<T>(this IList<T> list) where T : IArea
        {
            return list.Select(o => { return o.Area; }).ToArray();
        }

        internal static void ShowAreas<T>(this IList<T> list) where T : IArea
        {
            list.Select(o => { Console.WriteLine($"This {o.GetType().Name}'s area is {o.Area}"); return o; }).ToArray();
        }

        public static double SumAreaArray<T>(this IList<T> list) where T : IArea
        {
            return list.ToAreaArray().Sum();
        }

        public static void ShowShapes<T>(this IList<T> list) where T : IArea
        {
            list.ShowAreas();
            Console.WriteLine($"Total Sum of all Shape Areas: {list.SumAreaArray()}");
            Console.ReadLine();
        }

        public static IList<IArea> ToIArea<T>(this IList<T> shapes) where T : Shape
        {
            return shapes.Select(shape => shape as IArea).ToList();
        }
    }
}
