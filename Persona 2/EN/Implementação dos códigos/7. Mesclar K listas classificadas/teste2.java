import java.util.PriorityQueue;

public class teste2 {
    public static class ListNode {
        int val;
        ListNode next;
        ListNode(int val) {
            this.val = val;
        }
    }

    public static ListNode mergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode> minHeap = new PriorityQueue<>((a, b) -> a.val - b.val);

        // Add the head of each list to the priority queue
        for (ListNode node : lists) {
            if (node != null) {
                minHeap.add(node);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (!minHeap.isEmpty()) {
            ListNode minNode = minHeap.poll();
            current.next = minNode;
            current = current.next;
            
            if (minNode.next != null) {
                minHeap.add(minNode.next);
            }
        }

        return dummy.next;
    }
}
