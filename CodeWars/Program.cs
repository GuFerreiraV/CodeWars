using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    internal class Program
    {
        public static void Main (string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione um desafio do CodeWars para executar:");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(" 1. Disemvowel");
                Console.WriteLine(" 2. Descending Order");
                Console.WriteLine(" 3. Opposite Number");
                Console.WriteLine(" 4. Binary Array To Number");
                Console.WriteLine(" 5. Century From Year");
                Console.WriteLine(" 6. Ordered Count of Characters");
                Console.WriteLine(" 7. Reverse Words");
                Console.WriteLine(" 8. Delta Bits (ConvertBits)");
                Console.WriteLine(" 9. Find All Occurrences of a Number");
                Console.WriteLine("10. Interlocking Binary Pairs");
                Console.WriteLine("11. Equation Reversal");
                Console.WriteLine("12. Death By Coffee");
                Console.WriteLine("13. Rotate Array");
                Console.WriteLine("14. Sum of Numbers");
                Console.WriteLine("15. Find Smallest Int");
                Console.WriteLine("16. Find Array by Index");
                Console.WriteLine("17. Pangram");
                Console.WriteLine("18. Delete Nth");
                Console.WriteLine("19. Counting Sheeps");
                Console.WriteLine("20. Growth of a Population");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(" 0. Sair");
                Console.WriteLine("-------------------------------------------------");

                Console.Write("\nDigite sua escolha: ");
                string choice = Console.ReadLine();

                Console.WriteLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Executando: Disemvowel");
                        Console.WriteLine("Input: \"This website is for losers LOL!\"");
                        Console.WriteLine($"Resultado: {remove_vowels.Disemvowel("This website is for losers LOL!")}");
                        break;
                    case "2":
                        Console.WriteLine("Executando: Descending Order");
                        Console.WriteLine("Input: 345343");
                        Console.WriteLine($"Resultado: {sorting_number_descending.DescendingOrder(345343)}");
                        break;
                    case "3":
                        Console.WriteLine("Executando: Opposite Number");
                        Console.WriteLine("Input: -5800");
                        Console.WriteLine($"Resultado: {opposite_number.Opposite(-5800)}");
                        break;
                    case "4":
                        Console.WriteLine("Executando: Binary Array To Number");
                        Console.WriteLine("Input: new int[] { 0, 0, 0, 1 }");
                        Console.WriteLine($"Resultado: {Kata.binaryArrayToNumber(new int[] { 0, 0, 0, 1 })}");
                        break;
                    case "5":
                        Console.WriteLine("Executando: Century From Year");
                        Console.WriteLine("Input: 1705");
                        Console.WriteLine($"Resultado: {CenturyFromYear.СenturyFromYear(1705)}");
                        break;
                    case "6":
                        Console.WriteLine("Executando: Ordered Count of Characters");
                        Console.WriteLine("Input: \"abracadabra\"");
                        List<Tuple<char, int>> result = OrderedCountofCharacters.OrderedCount("abracadabra");
                        Console.WriteLine("Resultado:");
                        foreach (var item in result)
                        {
                            Console.WriteLine($"  Caractere: '{item.Item1}', Contagem: {item.Item2}");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Executando: Reverse Words");
                        Console.WriteLine("Input: \"Hello World\"");
                        Console.WriteLine($"Resultado: {ReverseWords.Reverse("Hello World")}");
                        break;
                    case "8":
                        Console.WriteLine("Executando: Delta Bits");
                        Console.WriteLine("Input: 31, 14");
                        Console.WriteLine($"Resultado: {DeltaBits.ConvertBits(31, 14)}");
                        break;
                    case "9":
                        Console.WriteLine("Executando: Find All Occurrences");
                        Console.WriteLine("Input: new int[] { 1, 2, 3, 2, 1 }, 2");
                        Console.WriteLine($"Resultado: [{string.Join(", ", CheckAllValuesInTheArray.FindAll(new int[] { 1, 2, 3, 2, 1 }, 2))}]");
                        break;
                    case "10":
                        Console.WriteLine("Executando: Interlocking Binary Pairs");
                        Console.WriteLine("Input: 5, 10");
                        Console.WriteLine($"Resultado: {InterlockingBinaryPairs.Interlockable(5, 10)}");
                        break;
                    case "11":
                        Console.WriteLine("Executando: Equation Reversal");
                        Console.WriteLine("Input: \"3+4*2-1\"");
                        Console.WriteLine($"Resultado: {EquationReversal.solve("3+4*2-1")}");
                        break;
                    case "12":
                        Console.WriteLine("Executando: Death By Coffee");
                        Console.WriteLine("Input: 2004, 3, 28");
                        var coffeeLimits = DeathByCoffee.CoffeeLimits(2004, 3, 28);
                        Console.WriteLine($"Resultado: (Regular: {coffeeLimits.Item1}, Decaf: {coffeeLimits.Item2})");
                        break;
                    case "13":
                        Console.WriteLine("Executando: Rotate Array");
                        Console.WriteLine("Input: new object[] { 1, 2, 3, 4, 5 }, 2");
                        Console.WriteLine($"Resultado: [{string.Join(", ", RotateArray.Rotate(new object[] { 1, 2, 3, 4, 5 }, 2))}]");
                        break;
                    case "14":
                        Console.WriteLine("Executando: Sum of Numbers");
                        Console.WriteLine("Input: 5, -1");
                        Console.WriteLine($"Resultado: {sumOfNumbers.GetSum(5, -1)}");
                        break;
                    case "15":
                        Console.WriteLine("Executando: Find Smallest Int");
                        Console.WriteLine("Input: new int[] { 78, 56, 232, 12, 18 }");
                        Console.WriteLine($"Resultado: {FindSmallestInt.FindSmallestInteger(new int[] { 78, 56, 232, 12, 18 })}");
                        break;
                    case "16":
                        Console.WriteLine("Executando: Find Array by Index");
                        Console.WriteLine("Input: new object[]{{1, 2, 3, 4, 5}}, new int[]{{0, 2}}");
                        Console.WriteLine($"Resultado: [{string.Join(", ", FindArray.FindArrayI(new object[] { 1, 2, 3, 4, 5 }, new int[] { 0, 2 }))}]");
                        break;
                    case "17":
                        Console.WriteLine("Executando: Pangram");
                        Console.WriteLine("Input: \"The quick brown fox jumps over the lazy dog\"");
                        Console.WriteLine($"Resultado: {Pangram.IsPangram("The quick brown fox jumps over the lazy dog")}");
                        break;
                    case "18":
                        Console.WriteLine("Executando: DeleteN");
                        Console.WriteLine("Input: [1,2,3,1,2,1,2,3] ");
                        Console.WriteLine($"Resultado: [{string.Join(", ", DeleteNth.DeleteN(new int[] { 1, 2, 3, 1, 2, 1, 2}, 2))}]");
                        break;
                    case "19":
                        Console.WriteLine("Executando: Counting Sheeps");
                        Console.WriteLine("Input: [false, true, false, false, true] ");
                        Console.WriteLine($"Resultado: [{string.Join(", ", CountingSheeps.CountSheeps(new bool[] { false, true, false, false, true }))}]");
                        break;
                    case "20":
                        Console.WriteLine("Executando: Growth Population");
                        Console.WriteLine("Input: [1500, 5, 100, 5000] ");
                        Console.WriteLine($"Anos: { GrowthPopulation.NbYear(1500, 5, 100, 5000)}");
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
