/// <summary>
/// Consecutive Digit Constraints - 5 kyu - O(n)
/// Write a function that takes a number n and returns the number of n digit numbers (without leading zeros) that no three consecutive digits have a sum greater than 9
/// </summary>

using System;
using System.Numerics;

public class ConsecutiveDigitConstraints
{
    public static BigInteger NumberOfNumbers (int n)
    {
        if (n == 1) return 9;

        BigInteger[,] dp = new BigInteger[10, 10];

        for (int index1 = 1; index1 <= 9; index1++)
        {
            for (int index2 = 0; index2 <= 9; index2++)
            {
                if (index1 + index2 <= 9)
                {
                    dp[index1, index2] = 1;
                }
            }
        }

        if (n == 2)
        {
            BigInteger sum2 = 0;
            foreach (var val in dp) sum2 += val;
            return sum2; 
        }

        for (int step = 3; step <= n; step++)
        {
            BigInteger[,] nextDp = new BigInteger[10, 10];
            for (int index1 = 0; index1 <= 9; index1++)
            {
                for (int index2 = 0; index2 <= 9; index2++)
                {
                    if (dp[index1, index2] == 0) continue;

                    for (int index3 = 0; index3 <= 9; index3++)
                    {
                        if (index1 + index2 + index3 <= 9)
                        {
                            nextDp[index2, index3] += dp[index1, index2];
                        }
                    }
                }
            }
            dp = nextDp;
        }

        BigInteger total = 0;
        foreach (var val in dp) total += val;
        return total;
    }
}