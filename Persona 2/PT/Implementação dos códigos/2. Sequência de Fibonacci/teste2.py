def fibonacci_memoization(n, memo={}):
    if n <= 1:
        return n
    if n not in memo:
        memo[n] = fibonacci_memoization(n - 1, memo) + fibonacci_memoization(n - 2, memo)
    return memo[n]

n = 50  # Você pode mudar o valor de n para testar
print(f"Fibonacci of {n} is {fibonacci_memoization(n)}")
