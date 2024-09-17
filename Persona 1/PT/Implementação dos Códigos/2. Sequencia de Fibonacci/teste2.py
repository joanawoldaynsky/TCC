# fibonacci.py
def fibonacci(n):
    if n <= 0:
        return "Input should be a positive integer"
    elif n == 1:
        return 0
    elif n == 2:
        return 1
    else:
        a, b = 0, 1
        for _ in range(n - 2):
            a, b = b, a + b
        return b

# Testando a função
if __name__ == "__main__":
    n = int(input("Enter a number: "))
    print(f"Fibonacci({n}) = {fibonacci(n)}")
