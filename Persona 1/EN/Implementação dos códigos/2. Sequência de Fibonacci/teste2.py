def fibonacci(n):
    a, b = 0, 1
    print(a, b, end=" ")

    for _ in range(2, n):
        a, b = b, a + b
        print(b, end=" ")

n = 50  # Example
fibonacci(n)
