using System;

class PalindromeCounter
{
    static void Main()
    {
        int start = 100; // Início do intervalo
        int end = 200;   // Fim do intervalo
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPalindrome(i))
            {
                count++;
            }
        }

        Console.WriteLine("Número de palíndromos: " + count);
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
