using System;
using System.Collections.Generic;
using System.Linq;
using ShapeLibrary.Model.Abstract;

namespace ShapeLibrary.Model.Extensions
{
    public static class List
    {
        internal static double[] ToAreaArray<T>(this IList<T> list) where T : IArea
        {
            return list.Select(o => o.Area).ToArray();
        }

        public static double SumAreaArray<T>(this IList<T> list) where T : IArea
        {
            return list.ToAreaArray().Sum();
        }
        internal static void ShowAreas<T>(this IList<T> list) where T : IArea
        {
            list.Select(o => { Console.WriteLine($"{o.ToString().GetLastString('.')}'s area:  {o.Area}");return o.Area;}).ToList();
        }

        public static void ShowShapes<T>(this IList<T> shapes)where T : IArea
        {
            shapes.ShowAreas();
            Console.WriteLine("\n----------------------------------------------\n");
            Console.WriteLine($"Sum of Shape Areas: {shapes.SumAreaArray()}");

            Console.ReadLine();
        }

        public static IList<IArea> ToIArea<T>(this IList<T> shapes) where T : Shape
        {
            return shapes.Select(o => o as IArea).ToList();
        }
    }
}