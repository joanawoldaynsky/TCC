def count_palindromes(s):
    n = len(s)
    dp = [False] * n
    count = 0

    for length in range(1, n + 1):
        new_dp = [False] * n
        for i in range(n - length + 1):
            j = i + length - 1
            if s[i] == s[j] and (length <= 2 or dp[i + 1]):
                new_dp[i] = True
                count += 1
        dp = new_dp

    return count
