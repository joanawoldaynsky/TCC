import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.stream.Stream;

public class teste2 {
    public static void main(String[] args) {
        List<Integer> numbers = new ArrayList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);

        permute(numbers, 0).forEach(System.out::println);
    }

    public static Stream<List<Integer>> permute(List<Integer> arr, int k) {
        if (k == arr.size()) {
            return Stream.of(new ArrayList<>(arr));
        }

        return Stream.concat(
            Stream.of(arr).flatMap(s -> Stream.empty()), 
            Stream.iterate(k, i -> i + 1)
                  .limit(arr.size() - k)
                  .flatMap(i -> {
                      Collections.swap(arr, i, k);
                      Stream<List<Integer>> perm = permute(arr, k + 1);
                      Collections.swap(arr, i, k);
                      return perm;
                  })
        );
    }
}
