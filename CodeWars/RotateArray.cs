using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RotateArray
    {
        public static object[] Rotate(object[] array, int n)
        {
            int length = array.Length;
            int rotation = n % length;

            if (rotation == 0)
            {
                return (object[])array.Clone();
            }
            ;
            if (rotation < 0)
            {
                rotation += length;
            }
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            int cort = length - rotation;
            var final = array.Skip(cort);
            var inicial = array.Take(cort);

            return final.Concat(inicial).ToArray();
        }
    }
}
