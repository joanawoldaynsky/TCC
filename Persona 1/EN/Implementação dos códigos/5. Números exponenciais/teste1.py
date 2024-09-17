def calculate_exponential(base, exponent):
    return base ** exponent

def main():
    base = float(input("Enter the base number: "))
    exponent = float(input("Enter the exponent: "))
    
    result = calculate_exponential(base, exponent)
    print(f"{base} raised to the power of {exponent} is {result}")

if __name__ == "__main__":
    main()
