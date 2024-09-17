using System;
using System.Collections.Generic;

class Permutation
{
    public static List<string> GetPermutations(string str)
    {
        List<string> permutations = new List<string>();
        Permute("", str, permutations);
        return permutations;
    }

    private static void Permute(string prefix, string str, List<string> permutations)
    {
        int n = str.Length;
        if (n == 0)
        {
            permutations.Add(prefix);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Permute(prefix + str[i], str.Substring(0, i) + str.Substring(i + 1), permutations);
            }
        }
    }

    static void Main()
    {
        string input = "ABC";
        List<string> result = GetPermutations(input);
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}
