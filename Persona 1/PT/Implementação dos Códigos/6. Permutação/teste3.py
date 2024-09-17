import itertools

def permute(elements):
    return list(itertools.permutations(elements))

# Exemplo de uso
elements = [1, 2, 3]
permutations = permute(elements)
for p in permutations:
    print(p)
