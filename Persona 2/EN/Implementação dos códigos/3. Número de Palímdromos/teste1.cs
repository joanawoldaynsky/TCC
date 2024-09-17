using System;
using System.Collections.Generic;

class PalindromeCounter
{
    static void Main()
    {
        List<string> words = new List<string> { "madam", "racecar", "apple", "radar", "level" };
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
        int left = 0;
        int right = word.Length - 1;
        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
