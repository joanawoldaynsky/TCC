public class teste3 {
    public static void main(String[] args) {
        String input = "abccba";
        System.out.println("Number of palindromes: " + countPalindromes(input));
    }

    public static int countPalindromes(String s) {
        int n = s.length();
        boolean[][] dp = new boolean[n][n];
        int count = 0;

        for (int gap = 0; gap < n; gap++) {
            for (int i = 0, j = gap; j < n; i++, j++) {
                if (gap == 0) {
                    dp[i][j] = true;
                } else if (gap == 1) {
                    dp[i][j] = (s.charAt(i) == s.charAt(j));
                } else {
                    dp[i][j] = (s.charAt(i) == s.charAt(j)) && dp[i + 1][j - 1];
                }

                if (dp[i][j]) {
                    count++;
                }
            }
        }

        return count;
    }
}
