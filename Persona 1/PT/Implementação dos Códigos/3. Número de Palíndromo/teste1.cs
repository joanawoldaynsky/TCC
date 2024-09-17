using System;

class Palindrome
{
    public static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;
        
        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        
        return originalNumber == reversedNumber;
    }

    static void Main(string[] args)
    {
        int number = 121; // você pode testar com outros números
        if (IsPalindrome(number))
        {
            Console.WriteLine(number + " é um palíndromo.");
        }
        else
        {
            Console.WriteLine(number + " não é um palíndromo.");
        }
    }
}
