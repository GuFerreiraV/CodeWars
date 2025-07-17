using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars
{
    internal class Program
    {

        public static void Main(string[] args) {
            Console.WriteLine(Disemvowel("This website is for losers LOL!"));
            Console.WriteLine(sorting_number_descending.DescendingOrder(345343));
            Console.WriteLine(Opposite(-5800));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 0, 0, 1 }));
            Console.WriteLine(СenturyFromYear(1705));
            List<Tuple<char, int>> result = OrderedCount("abracadabra");
            foreach (var item in result)
            {
                Console.WriteLine($"Caractere: '{item.Item1}', Contagem: {item.Item2}");
            }
            Console.WriteLine(Reverse("Hello World"));
            Console.WriteLine(ConvertBits(31, 14));
            Console.WriteLine(string.Join(", ", FindAll(new int[] { 1, 2, 3, 2, 1 }, 2)));
            Console.WriteLine(Interlockable(5, 10)); // verifica se dois números podem ser intercalados
            Console.WriteLine(solve("3+4*2-1")); // Reverte a equação
            Console.WriteLine(CoffeeLimits(2004, 3, 28)); // Limites de café e descafeinado
            Console.WriteLine(string.Join(", ", Rotate(new object[] { 1, 2, 3, 4, 5 }, 2))); // Rotaciona um array
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

        public static int СenturyFromYear(int year) => (int)Math.Ceiling((double)year / 100);

        public static int FindSmallestInt(int[] args) => args.OrderBy(n => n).First();

        public static object[] FindArray(object[] arr1, int[] arr2)
        {
            return arr2.Where(i => i >= 0 && i < arr1.Length)
              .Select(i => arr1[i])
              .ToArray();
        }

        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            return input
                .GroupBy(c => c)
                .Select(g => new Tuple<char, int>(g.Key, g.Count()))
                .OrderBy(t => input.IndexOf(t.Item1))
                .ToList();
        }

        public static string Reverse(string str) => string.Join(" ", str.Split(' ').Select(word => new string(word.Reverse().ToArray())));

        public static int ConvertBits(int a, int b)
        {
            int xor = a ^ b;
            int count = 0;

            while (xor > 0)
            {
                count++;
                xor = xor & (xor - 1);
            }
            return count;
        }

        // Encontrando todos os índices de um número em um array
        public static int[] FindAll(int[] array, int n)
        {
            List<int> Found = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    Found.Add(i);
                }
            }
            return Found.ToArray();
        }

        // Check if two unsigned long integers can be interlocked
        public static bool Interlockable(ulong a, ulong b)
        {
            return (a & b) == 0;
        }

        public static string solve(string eq)
        {

            string pattern = @"(\d+)|([a-zA-Z])|([*/+-])";

            MatchCollection matches = Regex.Matches(eq, pattern);
            List<string> tokens = new List<string>();

            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            tokens.Reverse();

            return string.Join("", tokens);
        }

        public static (int, int) CoffeeLimits(int year, int month, int day)
        {

            const int cafe = 0xCAFE;
            const int decaf = 0xDECAF;

            // 20040328
            string birth = $"{year}{month:D2}{day:D2}";
            long health = long.Parse(birth);

            int regularLimit = 0;
            int decafLimit = 0;

            long test = health;
            for (int cups = 1; cups <= 5000; cups++)
            {
                test += cafe;
                if (test.ToString("X").Contains("DEAD"))
                {
                    regularLimit = cups;
                    break;
                }
            }

            long test1 = health;
            for (int cups = 1; cups <= 5000; cups++)
            {
                test1 += decaf;
                if (test1.ToString("X").Contains("DEAD"))
                {
                    decafLimit = cups;
                    break;
                }
            }

            return (regularLimit, decafLimit);
        }

        public static object[] Rotate(object[] array, int n)
        {
            int length = array.Length;
            int rotation = n % length;

            if (rotation == 0)
            {
                return (object[])array.Clone();
            }
            ;
            if (rotation < 0)
            {
                rotation += length;
            }
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            int cort = length - rotation;
            var final = array.Skip(cort);
            var inicial = array.Take(cort);

            return final.Concat(inicial).ToArray();
        }
    }
}
