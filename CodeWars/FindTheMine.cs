/// <summary> 
/// Find The Mine - 6 kyu - O(n*m)
/// Write a function that accepts a 2D array, and returns the location of the mine. 
/// The mine is represented as the integer 1 in the 2D array. 
/// Areas in the 2D array that are not the mine will be represented as 0s. 
/// First element is the row index
/// Second element is the column index of the bomb location
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FindTheMine
    {
        public static Tuple<int, int> MineLocation (int[,] field)
        {
            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return null;
        }
    }
}
