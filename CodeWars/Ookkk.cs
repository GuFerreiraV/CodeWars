/// <summary> 
/// 
/// Ookkk Language - 5 kyu - O(N)
/// 
/// We've got a message from the Librarian. 
/// As usual there're many o and k in it and, as all codewarriors don't know "Ook" language we need that you translate this message.
/// 
/// Your task is to implement a function that takes the okkOookk message (a string) as input and returns a decoded human-readable string.
/// 
/// 'Ok, Ook, Ooo!' --> 'H' (01 001 000)
/// 'Ok, Ook, Ooo?  Okk, Ook, Ok?  Okk, Okk, Oo?  Okk, Okk, Oo?  Okk, Okkkk!' --> 'Hello'
/// 'Ok, Ok, Okkk?  Okk, Okkkk?  Okkk, Ook, O?  Okk, Okk, Oo?  Okk, Ook, Oo?  Ook, Ooook!' --> 'World!'
/// 
/// </summary>

using System;
using System.Diagnostics;
using System.Text;

namespace CodeWars
{  
    
    public class Ookkk{   
    
        public static string OkkOokOo(string okkOookk)
        {
            string[] palavras = okkOookk.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);        
            
            StringBuilder translate = new StringBuilder();

            foreach(var palavra in palavras)
            {
                string binary = "";

                foreach (char c in palavra) {
                    if (c == 'O' || c == 'o') binary += "0";
                    else if (c == 'k') binary += "1";
                }
                // Converter para caractere
                if(!string.IsNullOrEmpty(binary)){
                int decimalValue = Convert.ToInt32(binary, 2);
                translate.Append((char)decimalValue);
                }
            }

            return translate.ToString();
        }
    }
}

