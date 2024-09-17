using System;

class PalindromeCounter
{
    public static int CountPalindromes(string s)
    {
        int n = s.Length;
        int count = 0;

        bool[,] dp = new bool[n, n];

        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
            count++;
        }

        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                dp[i, i + 1] = true;
                count++;
            }
        }

        for (int length = 3; length <= n; length++)
        {
            for (int i = 0; i <= n - length; i++)
            {
                int j = i + length - 1;
                if (s[i] == s[j] && dp[i + 1, j - 1])
                {
                    dp[i, j] = true;
                    count++;
                }
            }
        }

        return count;
    }

    static void Main()
    {
        string s = "ababa";
        Console.WriteLine("Number of palindromes: " + CountPalindromes(s));
    }
}
