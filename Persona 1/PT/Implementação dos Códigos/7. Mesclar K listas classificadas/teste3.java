import java.util.PriorityQueue;

class ListNode {
    int val;
    ListNode next;
    ListNode(int val) { this.val = val; }
}

public class teste3 {
    public ListNode mergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode> heap = new PriorityQueue<>((a, b) -> a.val - b.val);
        
        // Adiciona o primeiro nó de cada lista ao heap
        for (ListNode node : lists) {
            if (node != null) {
                heap.add(node);
            }
        }
        
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        while (!heap.isEmpty()) {
            ListNode minNode = heap.poll();
            current.next = minNode;
            current = current.next;
            if (minNode.next != null) {
                heap.add(minNode.next);
            }
        }
        
        return dummy.next;
    }
}
