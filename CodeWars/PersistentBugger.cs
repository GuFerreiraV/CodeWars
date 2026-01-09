/// <summary>
/// Persistent Bugger - 6 kyu - O(logn*log(logn))
/// Write a function, persistence, 
/// that takes in a positive parameter num and returns its multiplicative persistence, 
/// which is the number of times you must multiply the digits in num until you reach a single digit.
/// 
/// 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit, there are 3 multiplications)
/// 999-- > 4 (because 9 * 9 * 9 = 729, 7 * 2 * 9 = 126, 1 * 2 * 6 = 12, and finally 1 * 2 = 2, there are 4 multiplications)
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PersistentBugger
    {
        public static int Persistence (long n) // 999
        {
            if (n < 10) return 0;             
            long r = 1;
            
            while(n > 0)
            {
              r *= n % 10;
                n /= 10;
            }
            
            return 1 + Persistence(r);
        }
    }
}
