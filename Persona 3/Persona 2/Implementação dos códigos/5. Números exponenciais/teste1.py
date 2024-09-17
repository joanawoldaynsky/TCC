from decimal import Decimal, getcontext

def fast_power(base, exponent):
    getcontext().prec = 50  # Definir precisão se necessário
    base = Decimal(base)
    result = Decimal(1)
    
    while exponent > 0:
        if exponent % 2 == 1:  # Se o expoente for ímpar
            result *= base
        base *= base  # Eleva a base ao quadrado
        exponent //= 2  # Reduz o expoente pela metade
        
    return result

base = 2.0
exponent = 10
result = fast_power(base, exponent)
print(f"{base}^{exponent} = {result}")
