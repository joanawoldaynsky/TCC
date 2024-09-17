def count_palindromes(s: str) -> int:
    n = len(s)
    dp = [[False] * n for _ in range(n)]
    count = 0

    for gap in range(n):
        for i in range(n - gap):
            j = i + gap
            if gap == 0:
                dp[i][j] = True
            elif gap == 1:
                dp[i][j] = (s[i] == s[j])
            else:
                dp[i][j] = (s[i] == s[j]) and dp[i + 1][j - 1]

            if dp[i][j]:
                count += 1

    return count

input_string = "abccba"
print("Number of palindromes:", count_palindromes(input_string))
