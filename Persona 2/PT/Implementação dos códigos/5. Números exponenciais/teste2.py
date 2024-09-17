import sys
import psutil

def memory_usage_psutil():
    process = psutil.Process()
    return process.memory_info().rss

def main():
    base = 2
    exponent = 1000

    mem_before = memory_usage_psutil()
    result = base ** exponent
    mem_after = memory_usage_psutil()

    print("Result:", result)
    print("Used memory:", mem_after - mem_before, "bytes")

if __name__ == "__main__":
    main()
