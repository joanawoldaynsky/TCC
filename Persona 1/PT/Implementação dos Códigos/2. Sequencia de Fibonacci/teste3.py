def fib(n):
    if n <= 1:
        return n
    
    fib_array = [0, 1]
    for i in range(2, n + 1):
        fib_array.append(fib_array[i - 1] + fib_array[i - 2])
    
    return fib_array[n]

n = 10  # Por exemplo, calcular o 10º número de Fibonacci
print(fib(n))
