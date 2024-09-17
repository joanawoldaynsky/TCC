using System;

public class PalindromeCounter
{
    public static void Main(string[] args)
    {
        string str = "ababa";
        Console.WriteLine(CountPalindromes(str));
    }

    public static int CountPalindromes(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        int count = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = i; j < n; j++)
            {
                if (s[i] == s[j] && (j - i < 3 || dp[i + 1, j - 1]))
                {
                    dp[i, j] = true;
                    count++;
                }
            }
        }
        return count;
    }
}
