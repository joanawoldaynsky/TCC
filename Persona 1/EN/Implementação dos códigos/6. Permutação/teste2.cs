using System;
using System.Collections.Generic;

class Permutations
{
    static void Main(string[] args)
    {
        string str = "ABC";
        List<string> result = new List<string>();
        Permute(str, 0, str.Length - 1, result);

        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }

    static void Permute(string str, int l, int r, List<string> result)
    {
        if (l == r)
        {
            result.Add(str);
        }
        else
        {
            for (int i = l; i <= r; i++)
            {
                str = Swap(str, l, i);
                Permute(str, l + 1, r, result);
                str = Swap(str, l, i); // backtrack
            }
        }
    }

    static string Swap(string str, int i, int j)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return new string(charArray);
    }
}
