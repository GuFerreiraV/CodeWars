/// <summary>
/// Pure odd digits primes - 6 kyu - O(n * sqrt(n)) | Pure function O(sqrt(m)) 
/// Create a function, only_oddDigPrimes(), 
/// that receive a positive integer n >= 3, and output a list with three values:
/// 
/// [number pure odd digit primes less than or equal to n, 
/// largest pure odd digit prime smaller than or equal to n, 
/// smallest pure odd digit prime larger than n]
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PureOddDigitsPrimes
    {
        public static long[] OnlyOddDigPrimes (long n)
        {
            long count = 0;
            long maiorMenorOuIgual = 0;
            
            for (long i = n; i >= 3; i--)
            {

                if (Pure(i))
                {
                    count++;
                    if (maiorMenorOuIgual == 0) maiorMenorOuIgual = i;
                }
            }


            long menorMaiorQueN = n + 1;
            while (true)
            {
                if (AllDigitsOdd(menorMaiorQueN) && Pure(menorMaiorQueN)) break;
                menorMaiorQueN++;
            }
            return new long[] { count, maiorMenorOuIgual, menorMaiorQueN };
        
            // bit-check
            static bool AllDigitsOdd(long x)
            {
                if (x <= 0) return false;
                while(x > 0)
                {
                    int d = (int)(x % 10);
                    if ((d & 1) == 0) return false;
                    x /= 10;
                }
                return true;
            }

        }


        public static bool Pure(long? n)
        {
            if (n < 3 || n % 2 == 0) return n == 2; 

            long limite = (long)Math.Sqrt(Convert.ToDouble(n));
            for (long i = 3; i <= limite; i += 2)
                if (n % i == 0) return false;

            long? temp = n;
            while (temp > 0)
            {
                if ((temp % 10) % 2 == 0) return false;
                temp /= 10;
            }

            return true;
        }
    }
}
