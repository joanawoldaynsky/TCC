public class teste1 {

    // Method to check if a string is a palindrome
    public static boolean isPalindrome(String s) {
        int left = 0;
        int right = s.length() - 1;

        while (left < right) {
            if (s.charAt(left) != s.charAt(right)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    // Method to count palindromes in a given string
    public static int countPalindromes(String s) {
        int count = 0;

        // Consider all substrings of the input string
        for (int i = 0; i < s.length(); i++) {
            for (int j = i + 1; j <= s.length(); j++) {
                String subStr = s.substring(i, j);
                if (isPalindrome(subStr)) {
                    count++;
                }
            }
        }

        return count;
    }

    // Main method to test the palindrome counter
    public static void main(String[] args) {
        String input = "abba";
        int result = countPalindromes(input);
        System.out.println("Number of palindromes in the string: " + result);
    }
}
