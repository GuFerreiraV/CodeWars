/// <summary>
/// Invert values - 8 kyu - (N)
/// Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.
/// [1, 2, 3, 4, 5] --> [-1, -2, -3, -4, -5]
/// [1, -2, 3, -4, 5] --> [-1, 2, -3, 4, -5]
/// [] --> []
/// 
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class InvertValues
    {
        public static int[] InvertValuess (int[] input)
        {
            if (input.Length == 0) return input;

            for(int i = 0; i < input.Length; i++) 
            {
                input[i] *= -1;
            }

            return input;
        }
    }
}
