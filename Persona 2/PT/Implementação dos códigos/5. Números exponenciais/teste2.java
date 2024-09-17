import java.math.BigInteger;

public class teste2 {
    public static void main(String[] args) {
        int base = 2;
        int exponent = 1000;
        Runtime runtime = Runtime.getRuntime();
        
        runtime.gc();
        long usedMemoryBefore = runtime.totalMemory() - runtime.freeMemory();
        
        BigInteger result = BigInteger.valueOf(base).pow(exponent);
        
        long usedMemoryAfter = runtime.totalMemory() - runtime.freeMemory();
        
        System.out.println("Result: " + result);
        System.out.println("Used memory: " + (usedMemoryAfter - usedMemoryBefore) + " bytes");
    }
}
