using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CheckAllValuesInTheArray
    {
        public static int[] FindAll(int[] array, int n)
        {
            List<int> Found = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    Found.Add(i);
                }
            }
            return Found.ToArray();
        }
    }
}

