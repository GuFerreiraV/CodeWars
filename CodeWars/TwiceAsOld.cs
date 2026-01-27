/// <summary>
/// Twice as old - 8 kyu - O(1)
/// 
/// Your function takes two arguments:
/// current father's age (years)
/// current age of his son (years)
/// 
/// Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old). 
/// The answer is always greater or equal to 0, no matter if it was in the past or it is in the future.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class TwiceAsOld
    {
        public static int TwiceAsOlds (int dadYears, int sonYears)
        {
            int x = dadYears - (2 * sonYears);
            if (x > 0)
            {
                return x;
            }else
            {
                return Math.Abs(x);
            }
        }
    }
}
