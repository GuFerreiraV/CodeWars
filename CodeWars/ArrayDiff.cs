/// <summary>
/// Array.diff - 6 kyu - O(N*M)
/// Implement a function that computes the difference between two lists. 
/// The function should remove all occurrences of elements from the first list (a) that are present in the second list (b). 
/// The order of elements in the first list should be preserved in the result.
/// 
/// If a = [1, 2] and b = [1], the result should be [2].
/// If a = [1, 2, 2, 2, 3] and b = [2], the result should be [1, 3].If a = [1, 2] and b = [1], the result should be [2].
/// If a = [1, 2, 2, 2, 3] and b = [2], the result should be [1, 3].
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ArrayDiff
    {
        public static int[] ArrayDiffFunction (int[] a, int[] b)
        {
            ;

            // armazena temporariamente os valores
            int[] temp = new int[a.Length];
            int count = 0;

            // elementos do a que não estão no b
            for (int i = 0; i < a.Length; i++) 
            {
               if(!Existe(b, a[i]))
                {
                    temp[count] = a[i];
                    count++;
                }
            }          

            // array final
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        // aux
        private static bool Existe(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return true;
            }
            return false;
        }
    }
}
