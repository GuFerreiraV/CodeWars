/// <summary>
/// Mean Square Error - 5 kyu - 
/// Complete the function that

/// accepts two integer arrays of equal length
/// compares the value each member in one array to the corresponding member in the other
/// squares the absolute value difference between those two values
/// and returns the average of those squared absolute value difference between each member pair.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class MeanSquareError
    {
        public static double Solution (int[] firstArray, int[] secondArray)
        {
            return firstArray.Zip(secondArray, (a, b) => Math.Pow(a - b, 2)).Sum() / firstArray.Length;
        }
    }
}
