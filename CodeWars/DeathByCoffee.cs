using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DeathByCoffee
    {
        public static (int, int) CoffeeLimits(int year, int month, int day)
        {

            const int cafe = 0xCAFE;
            const int decaf = 0xDECAF;

            // 20040328
            string birth = $"{year}{month:D2}{day:D2}";
            long health = long.Parse(birth);

            int regularLimit = 0;
            int decafLimit = 0;

            long test = health;
            for (int cups = 1; cups <= 5000; cups++)
            {
                test += cafe;
                if (test.ToString("X").Contains("DEAD"))
                {
                    regularLimit = cups;
                    break;
                }
            }

            long test1 = health;
            for (int cups = 1; cups <= 5000; cups++)
            {
                test1 += decaf;
                if (test1.ToString("X").Contains("DEAD"))
                {
                    decafLimit = cups;
                    break;
                }
            }

            return (regularLimit, decafLimit);
        }
    }
}
