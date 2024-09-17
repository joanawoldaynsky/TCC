def is_palindrome(word):
    return word == word[::-1]

def count_palindromes(words):
    return sum(1 for word in words if is_palindrome(word))

words = ["madam", "racecar", "apple", "radar", "level"]
palindrome_count = count_palindromes(words)
print(f"Number of palindromes: {palindrome_count}")
