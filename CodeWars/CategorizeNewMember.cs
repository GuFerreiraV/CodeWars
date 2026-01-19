/// <summary>
/// Categorize New Member - 7 kyu - O(N)
/// To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
/// In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
///
/// Input will consist of a list of pairs. 
/// Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.
/// 
/// Output will consist of a list of string values (in Haskell and C: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior (int[][] data)
        {
            
            for(int i = 0; i < data.Length; i++)
            {
               if (data[i][0] >= 55 && data[i][1] > 7) 
               {
                        yield return "Senior";
               }
                else
                {
                    yield return "Open";
                }
            }            
        }
    }
}
