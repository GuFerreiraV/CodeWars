/// <summary>
/// First Non Repeating Char - 5 kyu - O(n*m)
/// Write a function named first_non_repeating_letter† that takes a string input, and returns the first character that is not repeated anywhere in the string.
/// For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
/// As an added challenge, upper-and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.
// If a string contains all repeating characters, it should return an empty string ("");
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class FIrstNonRepeatingChar
    {
        public static string FirstNonRepeatingLetter (string s)
        {
            for (int i = 0; i < s.Length; ++i)
            {
                bool found = false;
                for(int j = 0; j < s.Length; ++j)
                {
                    if(i != j && char.ToLower(s[i]) == char.ToLower(s[j]))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return s[i].ToString();
                }
            }
            return "";
        }
    }
}
