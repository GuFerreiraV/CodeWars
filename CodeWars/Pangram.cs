using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Pangram
{
    public static bool IsPangram (string str)
    {
        string aux = "abcdefghijklmnopqrstuvwxyz";
        string strToLower = str.ToLower();
        HashSet<char> conjNecessarios = new HashSet<char>(
          aux.Where(c => Char.IsLetter(c))
        );
        HashSet<char> conjDisponiveis = new HashSet<char>(
          strToLower.Where(c => Char.IsLetter(c))
        );

        var faltando = conjNecessarios.Except(conjDisponiveis).OrderBy(c => c).ToList();

        if (faltando.Any())
        {
            //Console.WriteLine($"\n❌ FALHA na validação.");
            //Console.WriteLine($"Os seguintes caracteres necessários estão faltando na frase:");
            Console.WriteLine(string.Join(", ", faltando));
        }
        else
        {
            //Console.WriteLine("\n✅ SUCESSO! Todos os caracteres necessários foram encontrados.");
        }
        return conjDisponiveis.IsSupersetOf(conjNecessarios);

    }
}

