def power(base, exponent):
    result = 1
    current_base = base
    current_exponent = abs(exponent)
    
    while current_exponent > 0:
        if current_exponent % 2 == 1:
            result *= current_base
        current_base *= current_base
        current_exponent //= 2
    
    return result if exponent >= 0 else 1 / result

base = 2.0
exponent = 10
print(f"{base}^{exponent} = {power(base, exponent)}")
