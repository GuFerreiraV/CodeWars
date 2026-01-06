using System;
using System.Linq;

namespace CodeWars
{
    /// <summary>
    /// Count the number of Duplicates
    /// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
    /// The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
    /// </summary>
    public class CountingDuplicates
    {
        public static int DuplicateCount (string str)
        { 
            return str.ToLower()
                    .GroupBy(c => c)
                    .Where(g => g.Count() > 1)
                    .Count();
        }

    }
}
