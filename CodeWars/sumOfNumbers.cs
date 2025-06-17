using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class sumOfNumbers
{
    public static int GetSum(int a, int b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);

        int count = end - start + 1;

        return Enumerable.Range(start, count).Sum();
    }

}
