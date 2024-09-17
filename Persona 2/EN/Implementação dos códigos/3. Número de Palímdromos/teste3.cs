using System;

public class PalindromeCounter {
    public static int CountPalindromes(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        int count = 0;

        for (int length = 1; length <= n; length++) {
            for (int i = 0; i <= n - length; i++) {
                int j = i + length - 1;
                if (s[i] == s[j] && (length <= 2 || dp[i + 1, j - 1])) {
                    dp[i, j] = true;
                    count++;
                }
            }
        }
        return count;
    }

    public static void Main(string[] args) {
        string s = "ababa";
        Console.WriteLine("Number of palindromes: " + CountPalindromes(s));
    }
}
