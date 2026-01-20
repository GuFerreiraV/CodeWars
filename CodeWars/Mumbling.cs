/// <summary>
/// Mumbling - 7 kyu - O(N)
/// This time no story, no theory. The examples below show you how to write function accum:
/// accum("abcd") -> "A-Bb-Ccc-Dddd"
//  accum("RqaEzty")-> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Mumbling
    {
        public static string Accum (string s)
        {
            return string.Join("-", s.Select((letra, i) => char.ToUpper(letra) + new string(char.ToLower(letra), i)));
        }
    }
}
