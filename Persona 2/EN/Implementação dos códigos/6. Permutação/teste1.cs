using System;
using System.Collections.Generic;

class Permutation
{
    static void Main()
    {
        string str = "ABC";
        List<string> permutations = new List<string>();
        Permute(str, 0, str.Length - 1, permutations);
        foreach (var perm in permutations)
        {
            Console.WriteLine(perm);
        }
    }

    private static void Permute(string str, int l, int r, List<string> permutations)
    {
        if (l == r)
        {
            permutations.Add(str);
        }
        else
        {
            for (int i = l; i <= r; i++)
            {
                str = Swap(str, l, i);
                Permute(str, l + 1, r, permutations);
                str = Swap(str, l, i); // backtrack
            }
        }
    }

    private static string Swap(string a, int i, int j)
    {
        char temp;
        char[] charArray = a.ToCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return new string(charArray);
    }
}
