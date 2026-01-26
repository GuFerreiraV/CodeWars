/// <summary>
/// Domain Name Validator - 5 kyu - O(N)
/// Rules: 
/// Domain name may contain subdomains (levels), hierarchically separated by . (period) character
/// Domain name must not contain more than 127 levels, including top level (TLD)
/// Domain name must not be longer than 253 characters.
/// Level names must be composed out of lowercase and uppercase ASCII letters, digits and - (minus sign) character.
/// Level names must not start or end with - (minus sign) character.
/// Level names must not be longer than 63 characters.
/// Top level (TLD) must not be fully numerical
/// 
/// Additionally:
/// Domain name must contain at least one subdomain (level) apart from TLD
/// Top level validation must be naive - ie. TLDs nonexistent in IANA register are still considered valid as long as they adhere to the rules given above.
/// 
/// Examples:
/// 
/// validate('CODEWARS.COM') == True
/// validate('sub.codewars.com') == True
/// validate('codewars.com-') == False
/// validate('.codewars.com') == False
/// validate('example@codewars.com') == False
/// validate('127.0.0.1') == False
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DomainNameValidator
    {
        public static bool validate (string domain)
        {
            // Null, Empty or than 253
            if (string.IsNullOrEmpty(domain) || domain.Length > 253) return false;

            // levels broken
            string[] levels = domain.Split('.');

            // may contain subdomain and < 127
            if (levels.Length < 2 || levels.Length > 127) return false;

            // not be fully numerical
            string TLD = levels.Last();
            if (TLD.All(char.IsDigit)) return false;

            // percorrendo os levels
            foreach(var level in levels)
            {
                // must not be empty
                if (string.IsNullOrEmpty(level)) return false;

                // limit 63
                if (level.Length > 63) return false;

                // must not start or end with - .
                if (level.StartsWith('-') || level.EndsWith('-')) return false;

                // ASCII letters, digits and -
                foreach(char c in level)
                {
                    if (!Regex.IsMatch(level, "^[a-zA-Z0-9-]+$")) return false;
                }
            }

            return true;
        }
    }
}
