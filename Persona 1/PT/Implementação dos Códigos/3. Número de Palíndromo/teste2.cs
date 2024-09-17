using System;
using System.Collections.Generic;

class PalindromeChecker
{
    static void Main()
    {
        List<int> palindromes = new List<int>();
        int limit = 100000; // Defina um limite apropriado para testes
        for (int i = 0; i < limit; i++)
        {
            if (IsPalindrome(i))
            {
                palindromes.Add(i);
            }
        }
        Console.WriteLine("Total palindromes found: " + palindromes.Count);
    }

    static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
