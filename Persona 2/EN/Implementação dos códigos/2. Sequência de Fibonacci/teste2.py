def print_fibonacci(n):
    if n <= 0:
        return

    a, b = 0, 1
    print(a, end=' ')

    for _ in range(1, n):
        print(b, end=' ')
        a, b = b, a + b

# Example: print the first 10 Fibonacci numbers
print_fibonacci(10)
