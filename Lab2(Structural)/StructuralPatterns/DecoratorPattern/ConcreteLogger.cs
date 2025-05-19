namespace DecoratorPattern;

public class ConcreteLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine(message);
    }
}