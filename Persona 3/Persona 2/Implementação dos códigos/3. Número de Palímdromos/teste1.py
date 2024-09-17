def is_palindrome(word):
    left, right = 0, len(word) - 1
    while left < right:
        if word[left] != word[right]:
            return False
        left += 1
        right -= 1
    return True

def count_palindromes(words):
    count = 0
    for word in words:
        if is_palindrome(word):
            count += 1
    return count

words = ["radar", "hello", "level", "world", "deified"]
palindrome_count = count_palindromes(words)
print("Number of palindromes:", palindrome_count)
