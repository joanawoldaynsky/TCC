import java.util.*;

public class teste2 {
    public static List<Integer> mergeKLists(List<List<Integer>> lists) {
        PriorityQueue<int[]> pq = new PriorityQueue<>(Comparator.comparingInt(o -> o[0]));
        List<Integer> mergedList = new ArrayList<>();

        for (int i = 0; i < lists.size(); i++) {
            if (!lists.get(i).isEmpty()) {
                pq.add(new int[]{lists.get(i).get(0), i, 0});
            }
        }

        while (!pq.isEmpty()) {
            int[] current = pq.poll();
            mergedList.add(current[0]);
            int listIndex = current[1];
            int elementIndex = current[2];

            if (elementIndex + 1 < lists.get(listIndex).size()) {
                pq.add(new int[]{lists.get(listIndex).get(elementIndex + 1), listIndex, elementIndex + 1});
            }
        }

        return mergedList;
    }

    public static void main(String[] args) {
        List<List<Integer>> lists = Arrays.asList(
                Arrays.asList(1, 4, 5),
                Arrays.asList(1, 3, 4),
                Arrays.asList(2, 6)
        );
        System.out.println(mergeKLists(lists));
    }
}
