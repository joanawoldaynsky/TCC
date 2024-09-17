def is_palindrome(number):
    str_num = str(number)
    return str_num == str_num[::-1]

def count_palindromes(start, end):
    count = 0
    for number in range(start, end + 1):
        if is_palindrome(number):
            count += 1
    return count

start = 100  # Início do intervalo
end = 200    # Fim do intervalo

count = count_palindromes(start, end)
print(f"Número de palíndromos: {count}")
