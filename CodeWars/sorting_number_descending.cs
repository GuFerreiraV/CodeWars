using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{

    public class sorting_number_descending
    {
        public static int DescendingOrder(int num)
        {
            var orderNumbers = new string(num
                .ToString() // Converte int p/ string
                .OrderByDescending(n => n) // Ordena de forma decrescente
                .ToArray()
                );

            return int.Parse(orderNumbers);
        }
    }
}