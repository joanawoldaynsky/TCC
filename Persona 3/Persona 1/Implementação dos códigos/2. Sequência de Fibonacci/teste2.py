def fibonacci(n):
    a, b = 0, 1
    for _ in range(2, n):
        a, b = b, a + b
    return b

n = 50  # Exemplo
print(fibonacci(n))
