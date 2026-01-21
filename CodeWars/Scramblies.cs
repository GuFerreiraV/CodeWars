/// <summary>
/// Scramblies -  5 kyu - 
/// Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.
/// Notes:
/// Only lower case letters will be used (a-z). No punctuation or digits will be included.
/// Performance needs to be considered.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Scramblies
    {
        public static bool Scramble (string str1, string str2)
        {
            Dictionary<char, int> estoque = new Dictionary<char, int>();

            foreach (char letra in str1)
            {
                if (estoque.ContainsKey(letra))
                    estoque[letra]++;
                else
                    estoque[letra] = 1;
            }

            foreach (char letra in str2)
            {
                if (!estoque.ContainsKey(letra) || estoque[letra] == 0)
                {
                    return false;
                }

                estoque[letra]--;
            }
            return true;
        }
    }
}
