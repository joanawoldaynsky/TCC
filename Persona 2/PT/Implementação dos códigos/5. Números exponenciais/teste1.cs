using System;

class Program {
    static void Main() {
        double baseNum = 2.0;
        double exponent = 3.0;
        double result = Math.Pow(baseNum, exponent);
        
        Console.WriteLine($"{baseNum} elevado a {exponent} é {result}");
    }
}
