using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class FindArray
    {
        public static object[] FindArrayI(object[] arr1, int[] arr2)
        {
            return arr2.Where(i => i >= 0 && i < arr1.Length)
              .Select(i => arr1[i])
              .ToArray();
        }
    }
}
