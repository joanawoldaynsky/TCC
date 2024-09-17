# Fibonacci sequence with memoization in Python
def fibonacci(n, memo={}):
    if n in memo:
        return memo[n]
    if n <= 1:
        return n
    memo[n] = fibonacci(n-1, memo) + fibonacci(n-2, memo)
    return memo[n]

# Example usage
n = 10
print(f"Fibonacci({n}) = {fibonacci(n)}")
