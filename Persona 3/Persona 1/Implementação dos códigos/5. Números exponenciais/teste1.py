def fast_exponential(base, exponent):
    result = 1
    while exponent > 0:
        if exponent % 2 == 1:
            result *= base
        base *= base
        exponent //= 2
    return result

base = 2
exponent = 3
result = fast_exponential(base, exponent)
print(f"{base}^{exponent} = {result}")
