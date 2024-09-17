def power(base, exponent):
    if exponent == 0:
        return 1
    half = power(base, exponent // 2)
    if exponent % 2 == 0:
        return half * half
    else:
        if exponent > 0:
            return base * half * half
        else:
            return (half * half) / base

if __name__ == "__main__":
    base = 2.0
    exponent = 10
    print(f"{base}^{exponent} = {power(base, exponent)}")
