using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
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
    public static bool IsIsogram (string str)
    {
        str = str.ToLower();

        HashSet<char> letras_encontradas = new HashSet<char>();

        foreach(char c in str){
            if(!Char.IsLetter(c))
            {
                continue;
            }
            if (letras_encontradas.Contains(c))
            {
                return false;
            }
            letras_encontradas.Add(c);
        }
        return true;
    }
}

public class Program
{
    public static void Main ()
    {
        Console.WriteLine(Kata.IsPangram("Cwm fjord bank glyphs vext quiz"));
        Console.WriteLine(Kata.IsIsogram("clllpotubbuupppcaaocplaboiittummonibcmletnauomabeininnemeetc"));
    }
}