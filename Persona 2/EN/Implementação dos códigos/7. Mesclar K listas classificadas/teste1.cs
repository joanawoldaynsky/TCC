using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class MergeKSortedLists {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        foreach (var node in lists) {
            if (node != null) {
                pq.Enqueue(node, node.val);
            }
        }
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while (pq.Count > 0) {
            var node = pq.Dequeue();
            current.next = node;
            current = current.next;
            if (node.next != null) {
                pq.Enqueue(node.next, node.next.val);
            }
        }
        return dummy.next;
    }

    public static void Main(string[] args) {
        // Example usage
        // Create some sorted linked lists and merge them
   
    }
}