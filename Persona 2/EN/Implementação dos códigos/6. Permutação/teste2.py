def permute(s):
    result = []
    permute_helper(s, "", result)
    return result

def permute_helper(s, chosen, result):
    if len(s) == 0:
        result.append(chosen)
    else:
        for i in range(len(s)):
            c = s[i]
            remaining = s[:i] + s[i+1:]
            permute_helper(remaining, chosen + c, result)

if __name__ == "__main__":
    input_str = "abc"
    permutations = permute(input_str)
    for perm in permutations:
        print(perm)
