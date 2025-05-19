using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies;

public class MergeSort : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Merge Sort");
        var sorted = MergeSortRecursive(data);
        data.Clear();
        data.AddRange(sorted);
    }

    private List<int> MergeSortRecursive(List<int> data)
    {
        if (data.Count <= 1)
            return data;

        int mid = data.Count / 2;
        var left = MergeSortRecursive(data.GetRange(0, mid));
        var right = MergeSortRecursive(data.GetRange(mid, data.Count - mid));

        return Merge(left, right);
    }

    private List<int> Merge(List<int> left, List<int> right)
    {
        var result = new List<int>();
        int i = 0, j = 0;
        while (i < left.Count && j < right.Count)
        {
            if (left[i] <= right[j])
                result.Add(left[i++]);
            else
                result.Add(right[j++]);
        }

        result.AddRange(left.GetRange(i, left.Count - i));
        result.AddRange(right.GetRange(j, right.Count - j));
        return result;
    }
}