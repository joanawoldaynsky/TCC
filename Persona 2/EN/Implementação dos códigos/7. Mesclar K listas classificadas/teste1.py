from heapq import heappush, heappop

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def mergeKLists(lists):
    heap = []
    for l in lists:
        if l:
            heappush(heap, (l.val, l))
    dummy = ListNode(0)
    current = dummy
    while heap:
        val, node = heappop(heap)
        current.next = ListNode(val)
        current = current.next
        node = node.next
        if node:
            heappush(heap, (node.val, node))
    return dummy.next

# Example usage
# Create some sorted linked lists and merge them
