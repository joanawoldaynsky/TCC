using System;
using System.Collections.Generic;

class MergeKSortedLists
{
    public static List<int> MergeKLists(List<List<int>> lists)
    {
        SortedSet<(int val, int listIdx, int elementIdx)> pq = new SortedSet<(int, int, int)>();
        List<int> mergedList = new List<int>();

        for (int i = 0; i < lists.Count; i++)
        {
            if (lists[i].Count > 0)
            {
                pq.Add((lists[i][0], i, 0));
            }
        }

        while (pq.Count > 0)
        {
            var min = pq.Min;
            pq.Remove(min);
            mergedList.Add(min.val);

            int listIndex = min.listIdx;
            int elementIndex = min.elementIdx;

            if (elementIndex + 1 < lists[listIndex].Count)
            {
                pq.Add((lists[listIndex][elementIndex + 1], listIndex, elementIndex + 1));
            }
        }

        return mergedList;
    }

    static void Main(string[] args)
    {
        List<List<int>> lists = new List<List<int>>
        {
            new List<int> {1, 4, 5},
            new List<int> {1, 3, 4},
            new List<int> {2, 6}
        };
        List<int> result = MergeKLists(lists);
        Console.WriteLine(string.Join(", ", result));
    }
}
