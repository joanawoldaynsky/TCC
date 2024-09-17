from decimal import Decimal, getcontext

def power(base, exponent):
    getcontext().prec = 50  # Set precision
    result = Decimal(1)
    base = Decimal(base)
    for _ in range(exponent):
        result *= base
    return result

base = 2.0
exponent = 10
result = power(base, exponent)
print(f"{base}^{exponent} = {result}")
