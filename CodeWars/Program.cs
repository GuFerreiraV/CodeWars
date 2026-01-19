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
                Console.WriteLine("20. Growth of a Population.");
                Console.WriteLine("21. Rock, Paper, Scissors");
                Console.WriteLine("22. Divisible By ..");
                Console.WriteLine("23. Counting Duplicates.");
                Console.WriteLine("24. Word a10n (abbreviation) - 6 kyu - O(n).");
                Console.WriteLine("25. Find an area - 6 kyu - O(n)");
                Console.WriteLine("26. OnlineRPG - 8 kyu - O(1)");
                Console.WriteLine("27. FindTheMine - 6 kyu - O(N²)");
                Console.WriteLine("28. Persistent Bugger - 6 kyu - O(logn*log(logn))");
                Console.WriteLine("29. Find the odd int - 6 kyu - O(n)");
                Console.WriteLine("30. Take a Ten Minutes Walk - 6 kyu - O(1)");
                Console.WriteLine("31. Which are in - 6 kyu - O(N)");
                Console.WriteLine("32. Not Very Secure - 5 kyu - O(N)");
                Console.WriteLine("33. Pure Odd Digits Prime - 6 kyu - O(n * sqrt(n)) | Pure function O(sqrt(m))");
                Console.WriteLine("34. Convert PascalCase string into snake_case - 5 kyu - O(N)");
                Console.WriteLine("35. Conway's Look and Say - 5 kyu - O(N²)");
                Console.WriteLine("36. First Non Repeating Char - 5 kyu - O(n*m)");
                Console.WriteLine("37. Categorize New Member - 7 kyu - O(N)");
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
                    case "21":
                        Console.WriteLine("Executando: RockPaperScissors");
                        Console.WriteLine("Input: [p1: paper, p2: rock] ");
                        Console.WriteLine($"Resultado: {RockPaperScissors.Rps("paper", "rock")}");
                        break;
                    case "22":
                        Console.WriteLine("Executando: IsDivisibleBy");
                        Console.WriteLine("Input: (100,5,4,10,25,20)");
                        Console.WriteLine($"Resultado: {IsDivisibleBy.IsDivisible(100, 5, 4, 10, 25, 20)}");
                        break;
                    case "23":
                        Console.WriteLine("Executando: CountingDuplicates");
                        Console.WriteLine("Input: (ABBCcAD)");
                        Console.WriteLine($"Resultado: {CountingDuplicates.DuplicateCount("ABBCcAD")}");
                        break;
                    case "24":
                        Console.WriteLine("Executando: Word a10n");
                        Console.WriteLine("Input: (Elephant-rides are really funny )");
                        Console.WriteLine($"Resultado: {WordA10n.Abbreviate("Elephant-rides are really funny")}");
                        break;
                    case "25":
                        Console.WriteLine("Executando: Find an area");
                        Console.WriteLine("Input: ([-2, 1], [1, 4], [3, 2], [5, 6])");
                        Console.WriteLine($"Resultado: {FindAnArea.FindArea(new List<Point> 
                        { 
                            new Point(-2, 1), 
                            new Point(1, 4), 
                            new Point(3, 2), 
                            new Point(5, 6),
                        })}");
                        break;
                    case "26":
                        Console.WriteLine("Executando: OnlineRPG");
                        Console.WriteLine("Input: (100)");
                        Console.WriteLine($"Resultado: {OnlineRPG.PlayerRankUp(100)}");
                        break;
                    case "27":
                        Console.WriteLine("Executando: FindTheMine");
                        Console.WriteLine("Input: [0,0,0],[0,0,1],[0,0,0]");
                        Console.WriteLine($"Resultado: {FindTheMine.MineLocation(new int[,] 
                        { 
                            { 0, 0, 0 },
                            { 0, 0, 1 },
                            { 0, 0, 0 }
                        })}");
                        break;
                    case "28":
                        Console.WriteLine("Executando: Persistent Bugger ");
                        Console.WriteLine("Input: (999)");
                        Console.WriteLine($"Resultado: {PersistentBugger.Persistence(999)}");
                        break;
                    case "29":
                        Console.WriteLine("Executando: Find The Odd Int");
                        Console.WriteLine("Input: new int[] { 7, 1, 2, 2, 1 }");
                        Console.WriteLine($"Resultado: [{string.Join(", ", FindTheOddInt.find_it(new int[] { 7, 1, 2, 2, 1 }))}]");
                        break;
                    case "30":
                        Console.WriteLine("Executando: Take a Ten Minutes Walk");
                        Console.WriteLine("Input: new string[] {\"n\",\"s\",\"n\",\"s\",\"w\",\"e\",\"w\",\"e\",\"n\",\"s\"}");
                        Console.WriteLine($"Resultado: [{TakeATenMinutesWalk.IsValidWalk(new string[] {"n", "s","n", "s", "w", "e","w", "e", "n","s"})}]");
                        break;
                    case "31":
                        Console.WriteLine("Executando: Which Are In");
                        Console.WriteLine("Input: new string[] {a1 = \"arp\", \"live\", \"strong\"}, new string[] {a2 = \"lively\", \"alive\", \"harp\", \"sharp\", \"armstrong\"}");
                        Console.WriteLine($"Resultado: [{WhichAreIn.inArray(new string[] { "arp", "live", "strong" }, new string[] {"lively", "alive", "harp", "sharp", "armstrong"})}]");
                        break;
                    case "32":
                        Console.WriteLine("Executando: Not Very Secure");
                        Console.WriteLine("Input: PassWord");
                        Console.WriteLine($"Resultado: [{NotVerySecure.Alphanumeric("PassWord")}]");
                        break;
                    case "33":
                        Console.WriteLine("Executando: Pure Odd Digits Prime");
                        Console.WriteLine("Input: 40");
                        Console.WriteLine($"Resultado: [{string.Join(", ", PureOddDigitsPrimes.OnlyOddDigPrimes(40))}]");
                        break;
                    case "34":
                        Console.WriteLine("Executando: Convert Pascal Case");
                        Console.WriteLine("Input: IssoEPascal4Case");
                        Console.WriteLine($"Resultado: [{ConvertPascalCase.ToUnderscore("IssoEPascal4Case")}]");
                        break;
                    case "35":
                        Console.WriteLine("Executando: Conway's Look and Say");
                        Console.WriteLine("Input: 2");
                        Console.WriteLine($"Resultado: [{ConwayLookSay.LookSay(2)}]");
                        break;
                    case "36":
                        Console.WriteLine("Executando: Fisrt Non Repeating Char");
                        Console.WriteLine("Input: Sass");
                        Console.WriteLine($"Resultado: [{FIrstNonRepeatingChar.FirstNonRepeatingLetter("Sass")}]");
                        break;
                    case "37":
                        Console.WriteLine("Executando: Categorize New Member");
                        Console.WriteLine("Input: [60, 10], [20, 3], [50, 8]");
                        Console.WriteLine($"Resultado: [{string.Join(", ", CategorizeNewMember.OpenOrSenior(new int[][] { [60, 10], [20, 3], [50, 8] }))}]");
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
