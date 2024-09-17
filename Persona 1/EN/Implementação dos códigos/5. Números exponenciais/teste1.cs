using System;

class Exponential
{
    static void Main()
    {
        Console.Write("Enter the base number: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        
        double result = Math.Pow(baseNumber, exponent);
        
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
    }
}
