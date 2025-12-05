using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DeleteNth
    {
        public static int[] DeleteN (int[] arr, int x)
        {
            // [1,2,3,1,2,1,2,3] - o mesmo valor não pode aparecer mais de 3 vezes

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if (count > x)
                        {
                            arr = arr.Where((val, idx) => idx != j).ToArray();
                            j--; // Ajusta o índice após a remoção
                        }
                    }
                }
            }
            return arr;
        }
    }
}
