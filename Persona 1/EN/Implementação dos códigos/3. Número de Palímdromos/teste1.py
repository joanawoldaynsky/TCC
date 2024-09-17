def is_palindrome(s):
    return s == s[::-1]

def count_palindromes(s):
    count = 0
    length = len(s)
    
    # Consider all substrings of the input string
    for i in range(length):
        for j in range(i + 1, length + 1):
            sub_str = s[i:j]
            if is_palindrome(sub_str):
                count += 1

    return count

if __name__ == "__main__":
    input_str = "abba"
    result = count_palindromes(input_str)
    print("Number of palindromes in the string:", result)
