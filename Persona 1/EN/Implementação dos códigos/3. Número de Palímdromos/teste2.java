public class teste2 {
    public static void main(String[] args) {
        String s = "abba";
        System.out.println("Number of palindromes: " + countPalindromes(s));
    }

    public static int countPalindromes(String s) {
        int n = s.length();
        int count = 0;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j <= n; j++) {
                if (isPalindrome(s.substring(i, j))) {
                    count++;
                }
            }
        }
        return count;
    }

    private static boolean isPalindrome(String sub) {
        int len = sub.length();
        for (int i = 0; i < len / 2; i++) {
            if (sub.charAt(i) != sub.charAt(len - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}
