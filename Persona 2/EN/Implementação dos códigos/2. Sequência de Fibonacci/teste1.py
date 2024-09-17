def fibonacci(n):
    if n <= 1:
        return n
    else:
        return fibonacci(n - 1) + fibonacci(n - 2)

n = 10  # number of terms to display
for i in range(n):
    print(fibonacci(i), end=" ")
