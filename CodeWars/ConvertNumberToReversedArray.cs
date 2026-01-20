/// <summary>
/// Convert Number to reversed array of digits - 8 kyu - O(N)
/// Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
/// 35231 => [1,3,2,5,3]
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ConvertNumberToReversedArray
    {
        public static long[] Digitize (long n)
        {            
            return n
                .ToString()
                .Reverse()
                .Select(c => (long)char.GetNumericValue(c))
                .ToArray();
        }
    }
}
