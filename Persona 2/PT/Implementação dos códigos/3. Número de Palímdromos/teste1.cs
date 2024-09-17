using System;
using System.Collections.Generic;

class PalindromeCounter
{
    static void Main()
    {
        List<string> words = new List<string> { "radar", "hello", "level", "world", "deified" };
        int palindromeCount = CountPalindromes(words);
        Console.WriteLine("Number of palindromes: " + palindromeCount);
    }

    static int CountPalindromes(List<string> words)
    {
        int count = 0;
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsPalindrome(string word)
    {
        int n = word.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (word[i] != word[n - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
