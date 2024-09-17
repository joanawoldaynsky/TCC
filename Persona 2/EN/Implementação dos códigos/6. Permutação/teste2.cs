using System;
using System.Collections.Generic;

class Permutation {
    static void Main(string[] args) {
        string input = "abc";
        List<string> permutations = Permute(input);
        foreach (var perm in permutations) {
            Console.WriteLine(perm);
        }
    }

    public static List<string> Permute(string str) {
        List<string> result = new List<string>();
        PermuteHelper(str, "", result);
        return result;
    }

    private static void PermuteHelper(string str, string chosen, List<string> result) {
        if (str.Length == 0) {
            result.Add(chosen);
        } else {
            for (int i = 0; i < str.Length; i++) {
                char c = str[i];
                string remaining = str.Substring(0, i) + str.Substring(i + 1);
                PermuteHelper(remaining, chosen + c, result);
            }
        }
    }
}
