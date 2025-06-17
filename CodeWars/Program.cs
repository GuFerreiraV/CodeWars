using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {

        public static void Main(string[] args) {
            Console.WriteLine(remove_vowels.Disemvowel("This website is for losers LOL!"));
            Console.WriteLine(sorting_number_descending.DescendingOrder(345343));

        }

        public class remove_vowels
        {
            public static string Disemvowel(string str)
            {
                return new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            }
        }

 
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
