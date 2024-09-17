def is_palindrome(word):
    return word == word[::-1]

def count_palindromes(words):
    count = 0
    for word in words:
        if is_palindrome(word):
            count += 1
    return count

words = ["radar", "hello", "level", "world", "deified"]
palindrome_count = count_palindromes(words)
print("Number of palindromes:", palindrome_count)
