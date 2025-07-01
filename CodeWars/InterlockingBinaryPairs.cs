using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class InterlockingBinaryPairs
    {
            public static bool Interlockable(ulong a, ulong b)
            {
                return (a & b) == 0;
            }
        }
    }

