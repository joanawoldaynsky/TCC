using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class MergeKSortedLists {
    public static ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();

        foreach (var node in lists) {
            if (node != null) {
                queue.Enqueue(node, node.val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (queue.Count > 0) {
            ListNode node = queue.Dequeue();
            tail.next = node;
            tail = tail.next;

            if (node.next != null) {
                queue.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }

    public static void Main() {
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(5);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode l3 = new ListNode(2);
        l3.next = new ListNode(6);

        ListNode[] lists = new ListNode[] { l1, l2, l3 };

        ListNode result = MergeKLists(lists);
        while (result != null) {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}
