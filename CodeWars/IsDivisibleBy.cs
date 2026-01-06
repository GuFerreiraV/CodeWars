using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    /// <summary>
    ///     Create a function that checks if the first argument n is divisible by all other arguments (return true if no other arguments)
    ///     
    ///     (12,2)--> true because 12 is divisible by 2
    ///     (100,5,4,10,25,20)--> true
    ///     (12,7)--> false because 12 is not divisible by 7    
    /// 
    /// </summary>
    public class IsDivisibleBy
    {
        public static bool IsDivisible (params int[] numbers)
        {            
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[0] % numbers[i] != 0) return false;
            }
            return true;
        }
    }   
}
