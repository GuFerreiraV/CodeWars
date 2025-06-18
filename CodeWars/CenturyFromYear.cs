using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class CenturyFromYear
    {
        public static int СenturyFromYear(int year) => (int)Math.Ceiling((double)year / 100);
    }
}
