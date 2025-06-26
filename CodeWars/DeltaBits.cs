using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DeltaBits
    {
        public static int ConvertBits(int a, int b)
        {
            int xor = a ^ b;
            int count = 0;

            while (xor > 0)
            {
                count++;
                xor = xor & (xor - 1);
            }
            return count;
        }

        //public static void Main(string[] args) 
        //{
        //    Console.WriteLine(ConvertBits(31, 14));
        //}
    }
}
