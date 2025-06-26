using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class OrderedCountofCharacters
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            return input
                .GroupBy(c => c)
                .Select(g => new Tuple<char, int>(g.Key, g.Count()))
                .OrderBy(t => input.IndexOf(t.Item1))
                .ToList();
        }
    }
}
