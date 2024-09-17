import java.util.List;

public class teste1 {
    public static void main(String[] args) {
        List<String> words = List.of("madam", "racecar", "apple", "radar", "level");
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

    private static boolean isPalindrome(String word) {
        int left = 0;
        int right = word.length() - 1;
        while (left < right) {
            if (word.charAt(left) != word.charAt(right)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
