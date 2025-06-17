using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
   public class Kata
        {
            public static int binaryArrayToNumber(int[] BinaryArray) => BinaryArray.Aggregate(0, (acc, bit) => (acc << 1) | bit);
        }
}
