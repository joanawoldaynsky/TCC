using System;

class PalindromeNumber {
    public static bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int revertedNumber = 0;
        while (x > revertedNumber) {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }

        return x == revertedNumber || x == revertedNumber / 10;
    }

    static void Main() {
        int number = 12321;
        Console.WriteLine($"{number} is palindrome: {IsPalindrome(number)}");
    }
}
