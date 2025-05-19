using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern;

public class SortingContext
{
    private ISortStrategy _strategy;

    public SortingContext(ISortStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(ISortStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Sort(List<int> data)
    {
        Console.WriteLine("Sorting....");
        _strategy.Sort(data);
    }
}