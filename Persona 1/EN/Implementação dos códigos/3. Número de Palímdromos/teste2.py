def count_palindromes(s):
    n = len(s)
    count = 0

    def is_palindrome(sub):
        return sub == sub[::-1]

    for i in range(n):
        for j in range(i + 1, n + 1):
            if is_palindrome(s[i:j]):
                count += 1
    return count

# Example usage
s = "abba"
print("Number of palindromes:", count_palindromes(s))
