def permute(s, step=0):
    if step == len(s):
        print("".join(s))
    for i in range(step, len(s)):
        s_copy = [c for c in s]
        s_copy[step], s_copy[i] = s_copy[i], s_copy[step]
        permute(s_copy, step + 1)

if __name__ == "__main__":
    string = "ABC"
    permute(list(string))
