def permute(s):
    result = []
    _permute_helper(list(s), 0, len(s) - 1, result)
    return result

def _permute_helper(s, l, r, result):
    if l == r:
        result.append(''.join(s))
    else:
        for i in range(l, r + 1):
            s[l], s[i] = s[i], s[l]
            _permute_helper(s, l + 1, r, result)
            s[l], s[i] = s[i], s[l]  # backtrack

if __name__ == "__main__":
    string = "ABC"
    permutations = permute(string)
    for perm in permutations:
        print(perm)
