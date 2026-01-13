/// <summary>
/// Not very secure - 5 kyu - O(N)
/// 
/// In this example you have to validate if a user input string is alphanumeric. 
/// The given string is not nil/null/NULL/None, so you don't have to check that.
/// The string has the following conditions to be alphanumeric:
///
/// At least one character ("" is not valid)
/// Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
/// No whitespaces / underscore
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class NotVerySecure
    {
        public static bool Alphanumeric (string str) => Regex.IsMatch(str, @"^[a-zA-Z0-9,]+$") ? true : false;
    }
}
