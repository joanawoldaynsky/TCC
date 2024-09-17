using System;

class PalindromeCounter
{
    // Method to check if a string is a palindrome
    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    // Method to count palindromes in a given string
    public static int CountPalindromes(string s)
    {
        int count = 0;

        // Consider all substrings of the input string
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string subStr = s.Substring(i, j - i);
                if (IsPalindrome(subStr))
                {
                    count++;
                }
            }
        }

        return count;
    }

    // Main method to test the palindrome counter
    static void Main(string[] args)
    {
        string input = "abba";
        int result = CountPalindromes(input);
        Console.WriteLine("Number of palindromes in the string: " + result);
    }
}
