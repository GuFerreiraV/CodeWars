//// <summary>
///  Convert PascalCase string into snake_case - 5 kyu - O(n)
/// Complete the function/method so that it takes a PascalCase string and returns the string in snake_case notation. 
/// Lowercase characters can be numbers. 
/// If the method gets a number as input, it should return a string.
/// 
/// "MoviesAndBooks"  -->  "movies_and_books"
/// "App7Test"-- > "app7_test"
///  1-- > "1"
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ConvertPascalCase
    {
        public static string ToUnderscore (int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore (string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char character = str[i];

                if (i > 0)
                {
                    char previous = str[i - 1];
                    
                    if (char.IsUpper(character) || (char.IsLetter(character) && char.IsDigit(previous)))
                    {
                        result.Append('_');
                    }
                }                

                result.Append(char.ToLower(character));
            }
            return result.ToString();
        }
    }
}
