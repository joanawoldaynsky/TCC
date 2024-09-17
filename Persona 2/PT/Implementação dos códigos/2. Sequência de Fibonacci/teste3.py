def fibonacci(n, fib_cache={}):
    if n <= 1:
        return n
    if n not in fib_cache:
        fib_cache[n] = fibonacci(n - 1, fib_cache) + fibonacci(n - 2, fib_cache)
    return fib_cache[n]

n = 50  # Número para calcular a sequência de Fibonacci
print(fibonacci(n))
