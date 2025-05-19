using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies;

public class BubbleSort : ISortStrategy
{
    public void Sort(List<int> data)
    {
        Console.WriteLine("Bubble Sort");
        var n = data.Count;
        for (var i = 0; i < n - 1; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (data[j] < data[i])
                {
                    (data[i], data[j]) = (data[j], data[i]);
                }
            }
        }
    }
}