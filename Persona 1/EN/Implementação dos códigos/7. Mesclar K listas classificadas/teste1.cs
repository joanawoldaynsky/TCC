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

        var queue = new PriorityQueue<ListNode, int>();
        var dummy = new ListNode(0);
        var tail = dummy;

        foreach (var node in lists) {
            if (node != null) {
                queue.Enqueue(node, node.val);
            }
        }

        while (queue.Count > 0) {
            var node = queue.Dequeue();
            tail.next = node;
            tail = tail.next;

            if (tail.next != null) {
                queue.Enqueue(tail.next, tail.next.val);
            }
        }

        return dummy.next;
    }

    public static void Main(string[] args) {
        // Add your test cases here
    }
}
