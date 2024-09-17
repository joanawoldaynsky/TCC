using System;

class PalindromeCounter {
    public static void Main(string[] args) {
        string input = "abccba";
        Console.WriteLine("Number of palindromes: " + CountPalindromes(input));
    }

    public static int CountPalindromes(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        int count = 0;

        for (int gap = 0; gap < n; gap++) {
            for (int i = 0, j = gap; j < n; i++, j++) {
                if (gap == 0) {
                    dp[i, j] = true;
                } else if (gap == 1) {
                    dp[i, j] = (s[i] == s[j]);
                } else {
                    dp[i, j] = (s[i] == s[j]) && dp[i + 1, j - 1];
                }

                if (dp[i, j]) {
                    count++;
                }
            }
        }

        return count;
    }
}
