def fib(n):
    if n <= 1:
        return n
    
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    
    return b

n = 10  # Por exemplo, calcular o 10º número de Fibonacci
print(fib(n))
