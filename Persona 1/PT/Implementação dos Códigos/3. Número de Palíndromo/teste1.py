def is_palindrome(number):
    original_number = number
    reversed_number = 0
    
    while number != 0:
        digit = number % 10
        reversed_number = reversed_number * 10 + digit
        number //= 10
    
    return original_number == reversed_number

number = 121  # você pode testar com outros números
if is_palindrome(number):
    print(f"{number} é um palíndromo.")
else:
    print(f"{number} não é um palíndromo.")
