using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model.Extensions
{
    internal static class String
    {
        internal static string GetLastString(this string value, char delimiter)
        {
            var a = value.Split(delimiter);
            if (a.Length < 1)
                return value;

            return a[a.Length-1];
        }
        
    }
}
