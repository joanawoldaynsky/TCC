def get_permutations(s):
    permutations = []
    permute("", s, permutations)
    return permutations

def permute(prefix, s, permutations):
    n = len(s)
    if n == 0:
        permutations.append(prefix)
    else:
        for i in range(n):
            permute(prefix + s[i], s[:i] + s[i+1:], permutations)

if __name__ == "__main__":
    input_str = "ABC"
    result = get_permutations(input_str)
    for perm in result:
        print(perm)
