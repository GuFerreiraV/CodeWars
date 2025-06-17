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
            Console.WriteLine(Disemvowel("This website is for losers LOL!"));
            Console.WriteLine(sorting_number_descending.DescendingOrder(345343));
            Console.WriteLine(Opposite(-5800));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 0, 0, 1 }));
        }

  
            public static string Disemvowel(string str)
            {
                return new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
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


        public static int Opposite(int number) => -number;

        public static int GetSum(int a, int b) => Enumerable.Range(Math.Min(a,b), Math.Max(b, a)-Math.Min(a, b)+1).Sum();

        public static int BinaryArrayToNumber(int[] BinaryArray) => BinaryArray.Aggregate(0, (acc, bit) => (acc << 1) | bit);



} 
}
