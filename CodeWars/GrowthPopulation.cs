using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class GrowthPopulation
    {
        public static int NbYear (int p0, double percent, int aug, int p)
        {
            int years = 0;
            while (p0 < p)
            {
                double result = p0 + (p0 * percent / 100) + aug;
                p0 = (int)result;
                years++;
            }
            return years;
        } // O (log n)
    }
}
