public class remove_vowels
{
    public static string Disemvowel(string str)
    {
        return new string(str.Where(c => !"aeiouAEIOU".Contains(c))
            .ToArray());
    }
}
