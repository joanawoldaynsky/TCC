def is_palindrome(number):
    return str(number) == str(number)[::-1]

def main():
    palindromes = []
    limit = 100000  # Defina um limite apropriado para testes
    for i in range(limit):
        if is_palindrome(i):
            palindromes.append(i)
    print("Total palindromes found:", len(palindromes))

if __name__ == "__main__":
    main()
