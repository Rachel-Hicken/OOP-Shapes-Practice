using Shapes.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes.Model.Extension
{
    internal static class List
    {
        internal static double[] ToAreaArray<T>(this List<T> list) where T : IArea
        {
            return list.Select(o => { Console.WriteLine(o.Area); return o.Area; }).ToArray();
        }

        internal static double SumAreaArray<T>(this List<T> list) where T : IArea
        {
            return list.ToAreaArray().Sum();
        }

    }
}
