using System;
using System.Collections.Generic;

class Permutacao
{
    static void Main()
    {
        string str = "ABC";
        List<string> resultado = new List<string>();
        Permutar(str, "", resultado);
        foreach (string s in resultado)
        {
            Console.WriteLine(s);
        }
    }

    static void Permutar(string str, string prefixo, List<string> resultado)
    {
        if (str.Length == 0)
        {
            resultado.Add(prefixo);
        }
        else
        {
            for (int i = 0; i < str.Length; i++)
            {
                Permutar(str.Substring(0, i) + str.Substring(i + 1), prefixo + str[i], resultado);
            }
        }
    }
}
