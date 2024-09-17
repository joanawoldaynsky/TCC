from heapq import heappush, heappop

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def merge_k_lists(lists):
    min_heap = []
    for l in lists:
        if l:
            heappush(min_heap, (l.val, l))

    dummy = ListNode()
    current = dummy

    while min_heap:
        val, node = heappop(min_heap)
        current.next = node
        current = current.next
        if node.next:
            heappush(min_heap, (node.next.val, node.next))

    return dummy.next

# You can test the implementation here
