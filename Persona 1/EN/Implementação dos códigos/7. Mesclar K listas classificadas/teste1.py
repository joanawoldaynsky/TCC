from queue import PriorityQueue

class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

def mergeKLists(lists):
    if not lists:
        return None

    pq = PriorityQueue()
    dummy = ListNode(0)
    tail = dummy

    for l in lists:
        if l:
            pq.put((l.val, l))

    while not pq.empty():
        val, node = pq.get()
        tail.next = ListNode(val)
        tail = tail.next
        node = node.next
        if node:
            pq.put((node.val, node))

    return dummy.next

# Add your test cases here
