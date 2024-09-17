using System;

class PalindromeCounter {
    static void Main() {
        string s = "abba";
        Console.WriteLine("Number of palindromes: " + CountPalindromes(s));
    }

    static int CountPalindromes(string s) {
        int n = s.Length;
        int count = 0;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j <= n; j++) {
                if (IsPalindrome(s.Substring(i, j - i))) {
                    count++;
                }
            }
        }
        return count;
    }

    static bool IsPalindrome(string sub) {
        int len = sub.Length;
        for (int i = 0; i < len / 2; i++) {
            if (sub[i] != sub[len - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}
