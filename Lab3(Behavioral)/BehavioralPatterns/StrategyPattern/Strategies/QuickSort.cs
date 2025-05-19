using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies;

public class QuickSort : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Quick Sort");
        QuickSortRecursive(data, 0, data.Count - 1);
    }

    private void QuickSortRecursive(List<int> data, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(data, low, high);
            QuickSortRecursive(data, low, pi - 1);
            QuickSortRecursive(data, pi + 1, high);
        }
    }

    private int Partition(List<int> data, int low, int high)
    {
        int pivot = data[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (data[j] < pivot)
            {
                i++;
                (data[i], data[j]) = (data[j], data[i]);
            }
        }

        (data[i + 1], data[high]) = (data[high], data[i + 1]);

        return i + 1;
    }
}