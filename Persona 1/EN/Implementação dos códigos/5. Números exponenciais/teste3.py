def power(base, exponent):
    if exponent == 0:
        return 1
    half_power = power(base, exponent // 2)
    if exponent % 2 == 0:
        return half_power * half_power
    else:
        return base * half_power * half_power

if __name__ == "__main__":
    base = 2
    exponent = 10
    print(f"{base}^{exponent} = {power(base, exponent)}")
