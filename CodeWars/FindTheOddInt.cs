/// <summary>
/// 
/// Find the odd int - 6 kyu - O(n)
/// 
/// Given an array of integers, find the one that appears an odd number of times.
/// There will always be only one integer that appears an odd number of times.
/// [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FindTheOddInt
    {
        public static int find_it (int[] seq)
        {
            int result = 0;
            foreach(int i in seq)
            {
                result = result ^ i;
            }
            return result;
        }
    }
}
