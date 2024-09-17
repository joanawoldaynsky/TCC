public class teste3 {
    public static int countPalindromes(String s) {
        int n = s.length();
        boolean[][] dp = new boolean[n][n];
        int count = 0;

        for (int length = 1; length <= n; length++) {
            for (int i = 0; i <= n - length; i++) {
                int j = i + length - 1;
                if (s.charAt(i) == s.charAt(j) && (length <= 2 || dp[i + 1][j - 1])) {
                    dp[i][j] = true;
                    count++;
                }
            }
        }
        return count;
    }

    public static void main(String[] args) {
        String s = "ababa";
        System.out.println("Number of palindromes: " + countPalindromes(s));
    }
}
