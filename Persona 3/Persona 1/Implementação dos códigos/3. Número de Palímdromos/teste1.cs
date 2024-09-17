public static bool IsPalindrome(int number)
{
    // Números negativos não são palíndromos
    if (number < 0) return false;
    
    int divisor = 1;
    while (number / divisor >= 10)
    {
        divisor *= 10;
    }

    while (number != 0)
    {
        int leading = number / divisor;
        int trailing = number % 10;
        
        if (leading != trailing) return false;
        
        number = (number % divisor) / 10;
        divisor /= 100;
    }

    return true;
}
