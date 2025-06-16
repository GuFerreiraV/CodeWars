public class remove_vowels
{
    public static string Disemvowel(string str)
    {
        return new string(str.Where(c => !"aeiouAEIOU".Contains(c))
            .ToArray());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Disemvowel("This website is for losers LOL!"));
    }
}
