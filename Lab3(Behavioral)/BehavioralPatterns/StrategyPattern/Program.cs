using StrategyPattern;
using StrategyPattern.Strategies;

var sorter = new SortingContext(new BubbleSort());
var data = new List<int> {4, 2, 5, 1, 8, 23, 43, 12, 54, 0, 0};
sorter.Sort(data);
Console.WriteLine(string.Join(", ", data) + "\n");

sorter.SetStrategy(new MergeSort());
data = [4, 2, 5, 1, 8, 23, 43, 12, 54, 0, 0];
sorter.Sort(data);
Console.WriteLine(string.Join(", ", data) + "\n");

sorter.SetStrategy(new QuickSort());
data = [4, 2, 5, 1, 8, 23, 43, 12, 54, 0, 0];
sorter.Sort(data);
Console.WriteLine(string.Join(", ", data) + "\n");
