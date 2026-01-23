/// <summary>
/// Grashopper - Check for factor - 8 kyu - O(1)
/// This function should test if the factor is a factor of base.
/// Return true if it is a factor or false if it is not.
/// 
/// Factors are numbers you can multiply together to get another number.
/// 2 and 3 are factors of 6 because: 2 * 3 = 6
/// Note: base is a non-negative number, factor is a positive number.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class GrashopperCheckForFactor
    {
        public static bool CheckForFactor (int num, int factor)
        {
            if (num % factor == 0) return true;

            return false;
        }
    }
}
