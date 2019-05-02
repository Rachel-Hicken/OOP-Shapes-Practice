using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Extensions
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
            list.Select(o => { Console.WriteLine($"{o} {o.Area}");return o.Area;}).ToList();
        }
        
        
    }
}
