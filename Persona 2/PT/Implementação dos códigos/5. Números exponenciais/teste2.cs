using System;
using System.Numerics;

class Exponential
{
    static void Main()
    {
        int baseNum = 2;
        int exponent = 1000;
        
        long usedMemoryBefore = GC.GetTotalMemory(true);
        
        BigInteger result = BigInteger.Pow(baseNum, exponent);
        
        long usedMemoryAfter = GC.GetTotalMemory(true);
        
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Used memory: " + (usedMemoryAfter - usedMemoryBefore) + " bytes");
    }
}
