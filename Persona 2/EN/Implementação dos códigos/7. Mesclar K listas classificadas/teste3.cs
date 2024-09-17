using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

        foreach (var list in lists) {
            if (list != null) {
                minHeap.Enqueue(list, list.val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (minHeap.Count > 0) {
            ListNode node = minHeap.Dequeue();
            current.next = node;
            current = current.next;

            if (node.next != null) {
                minHeap.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}
