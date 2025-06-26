using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ReverseWords
    {
        public static string Reverse(string str) => string.Join(" ", str.Split(' ').Select(word => new string(word.Reverse().ToArray())));

    }
}
