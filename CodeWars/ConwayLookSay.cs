/// <summary>
/// Conway's Look and Say - 5 kyu - O(N²)
/// Your task is to create a function that will take an integer and return the result of the look-and-say function on that integer. 
/// This should be a general function that takes as input any positive integer, and returns an integer; 
/// inputs are not limited to the sequence which starts with "1".
/// Conway's Look-and-say sequence goes like this:
///
///    Start with a number.
///    Look at the number, and group consecutive digits together.
///    For each digit group, say the number of digits, then the digit itself.
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ConwayLookSay
    {
        public static ulong LookSay (ulong number)
        {
            int i = 0;
            string result = "";
            while(i < number.ToString().Length)
            {
                int count = 1;
                while (i + 1 < number.ToString().Length && number.ToString()[i] == number.ToString()[i + 1])
                {
                    count++; // Conta o número de vezes que o number[i] é igual a number[i+1]
                    i++;
                }
                result += count.ToString() + number.ToString()[i];
                i++;
            }
            return ulong.Parse(result);
        }
    }
}
