import java.util.*;

public class teste1 {
    public static class ListNode {
        int val;
        ListNode next;
        ListNode(int val) { this.val = val; }
    }

    public static ListNode mergeKLists(List<ListNode> lists) {
        PriorityQueue<ListNode> queue = new PriorityQueue<>(lists.size(), Comparator.comparingInt(a -> a.val));

        for (ListNode node : lists) {
            if (node != null) {
                queue.add(node);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (!queue.isEmpty()) {
            ListNode node = queue.poll();
            tail.next = node;
            tail = tail.next;

            if (node.next != null) {
                queue.add(node.next);
            }
        }

        return dummy.next;
    }

    public static void main(String[] args) {
        // Crie listas classificadas e adicione-as ao ArrayList
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(5);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode l3 = new ListNode(2);
        l3.next = new ListNode(6);

        List<ListNode> lists = new ArrayList<>();
        lists.add(l1);
        lists.add(l2);
        lists.add(l3);

        ListNode result = mergeKLists(lists);
        while (result != null) {
            System.out.print(result.val + " ");
            result = result.next;
        }
    }
}
