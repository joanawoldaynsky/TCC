def permute_manual(elements):
    def backtrack(start, end):
        if start == end:
            permutations.append(elements[:])
        for i in range(start, end):
            elements[start], elements[i] = elements[i], elements[start]
            backtrack(start + 1, end)
            elements[start], elements[i] = elements[i], elements[start]

    permutations = []
    backtrack(0, len(elements))
    return permutations

# Exemplo de uso
elements = [1, 2, 3]
permutations = permute_manual(elements)
for p in permutations:
    print(p)
