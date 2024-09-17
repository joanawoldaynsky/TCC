from heapq import heappush, heappop
from typing import List, Optional

class ListNode:
    def __init__(self, x: int = 0, next: Optional['ListNode'] = None):
        self.val = x
        self.next = next

class Solution:
    def mergeKLists(self, lists: List[Optional[ListNode]]) -> Optional[ListNode]:
        min_heap = []
        
        for l in lists:
            if l:
                heappush(min_heap, (l.val, l))
        
        dummy = ListNode(0)
        current = dummy
        
        while min_heap:
            val, node = heappop(min_heap)
            current.next = node
            current = current.next
            if node.next:
                heappush(min_heap, (node.next.val, node.next))
        
        return dummy.next
