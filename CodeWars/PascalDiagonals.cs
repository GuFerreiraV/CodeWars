/// <summary>
/// Pascal´s Diagonals - 5 kyu - O(N)
/// Create a function that returns an array containing the first l numbers from the nth diagonal of Pascal's triangle.
/// 
/// n = 0 should generate the first diagonal of the triangle (the ones).
/// The first number in each diagonal should be 1.
/// If l = 0, return an empty array.
/// Both n and l will be non-negative integers in all test cases.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PascalDiagonals
    {
        public static BigInteger[] GenerateDiagonal (int n, int l)
        {
            // 1
            /// 1 1
            /// 1 2 1
            /// 1 3 3 1
            /// 1 4 6 4 1

            BigInteger[] resultado = new BigInteger[l];
            if (l <= 0) return new BigInteger[0];
            BigInteger valor = BigInteger.One;

            resultado[0] = valor; // O valor inicial sempre será 1
            
            for (int i = 1; i < l; i++)
            {
                valor = (valor * ((n + i - 1) + 1)) / ((n + i - 1) + 1 - n);

                resultado[i] = valor;

            }

            return resultado;
        }
    }
}
