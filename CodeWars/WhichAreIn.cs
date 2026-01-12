/// <summary>
/// Which are in - 6 kyu - O(n)
/// 
/// Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
/// 
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class WhichAreIn
    {
        public static string[] inArray (string[] array1, string[] array2)
        {
            
            return array1.Where(str1 => array2.Any(str2 => str2.Contains(str1)))
                .Distinct()
                .Order()
                .ToArray();
        }
    }
}
