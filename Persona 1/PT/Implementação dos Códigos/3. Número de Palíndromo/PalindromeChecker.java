import java.util.ArrayList;
import java.util.List;

public class PalindromeChecker {
    public static void main(String[] args) {
        List<Integer> palindromes = new ArrayList<>();
        int limit = 100000; // Defina um limite apropriado para testes
        for (int i = 0; i < limit; i++) {
            if (isPalindrome(i)) {
                palindromes.add(i);
            }
        }
        System.out.println("Total palindromes found: " + palindromes.size());
    }

    public static boolean isPalindrome(int number) {
        String str = Integer.toString(number);
        int len = str.length();
        for (int i = 0; i < len / 2; i++) {
            if (str.charAt(i) != str.charAt(len - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}
