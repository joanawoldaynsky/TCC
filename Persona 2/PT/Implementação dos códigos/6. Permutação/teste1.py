def permutar(str):
    resultado = []
    permutar_aux(str, "", resultado)
    return resultado

def permutar_aux(str, prefixo, resultado):
    if len(str) == 0:
        resultado.append(prefixo)
    else:
        for i in range(len(str)):
            permutar_aux(str[:i] + str[i+1:], prefixo + str[i], resultado)

# Exemplo de uso
str = "ABC"
resultado = permutar(str)
for s in resultado:
    print(s)
