using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars
{
    /// <summary>
    /// Word a10n (abbreviation) - 6 kyu - O(n)
    /// Write a function that takes a string and turns any and all "words" (see below) within that string of length 4 or greater into an abbreviation, following these rules:
    /// A "word" is a sequence of alphabetical characters.By this definition, any other character like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two words (eg. "elephant" and "ride").
    /// The abbreviated version of the word should have the first letter, then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").
    /// Example: Elephant-rides are really funny 
    /// Elephant (6) - e6t
    /// rides (3) - r3s
    /// are (1)
    /// really (4) - r4y
    /// funny (3) - f3y
    /// output: e6t r3s are r4y f3y
    /// </summary>

    public class WordA10n
    {
        public static string Abbreviate (string input) => Regex.Replace(input, @"[a-zA-Z]+", m => m.Value.Length < 4 ? m.Value : $"{m.Value[0]}{m.Length - 2}{m.Value[^1]}");              
        
    }
}
