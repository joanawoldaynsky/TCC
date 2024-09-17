def power(a, b):
    result = 1
    while b > 0:
        if b % 2 == 1:
            result *= a
        a *= a
        b //= 2
    return result

if __name__ == "__main__":
    base = 3
    exponent = 10
    result = power(base, exponent)
    print(f"{base}^{exponent} = {result}")
