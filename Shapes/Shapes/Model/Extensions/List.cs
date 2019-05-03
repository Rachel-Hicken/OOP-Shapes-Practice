using System;
using System.Collections.Generic;
using System.Linq;
using Shapes.Model.Abstract;

namespace Shapes.Model.Extensions
{
    internal static class List
    {
        internal static double[] ToAreaArray<T>(this List<T> list) where T : IArea
        {
            return list.Select(o => o.Area).ToArray();
        }

        internal static double SumAreaArray<T>(this List<T> list) where T : IArea
        {
            return list.ToAreaArray().Sum();
        }
        internal static void ShowAreas<T>(this List<T> list) where T : IArea
        {
            list.Select(o => { Console.WriteLine($"{o.ToString().GetLastString('.')}'s area:  {o.Area}");return o.Area;}).ToList();
        }

        internal static void ShowShapes<T>(this List<T> shapes)where T : IArea
        {
            shapes.ShowAreas();
            Console.WriteLine("\n----------------------------------------------\n");
            Console.WriteLine($"Sum of Shape Areas: {shapes.SumAreaArray()}");

            Console.ReadLine();
        }
        
    }
}
