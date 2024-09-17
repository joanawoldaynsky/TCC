import java.util.List;
import java.util.ArrayList;

public class teste1 {
    public static void main(String[] args) {
        List<String> words = new ArrayList<>();
        words.add("radar");
        words.add("hello");
        words.add("level");
        words.add("world");
        words.add("deified");
        
        int palindromeCount = countPalindromes(words);
        System.out.println("Number of palindromes: " + palindromeCount);
    }

    public static int countPalindromes(List<String> words) {
        int count = 0;
        for (String word : words) {
            if (isPalindrome(word)) {
                count++;
            }
        }
        return count;
    }

    public static boolean isPalindrome(String word) {
        int n = word.length();
        for (int i = 0; i < n / 2; i++) {
            if (word.charAt(i) != word.charAt(n - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}
