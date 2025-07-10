using System.Text.RegularExpressions;

namespace CodeWars
{
    public class EquationReversal
    {
        public static string solve(string eq) {
        
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
    }
}
