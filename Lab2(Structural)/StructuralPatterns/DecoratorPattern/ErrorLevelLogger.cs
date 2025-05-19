namespace DecoratorPattern;

public class ErrorLevelLogger : Decorator
{
    public ErrorLevelLogger(Logger logger) : base(logger)
    {
    }

    public override void Log(string message)
    {
        _logger.Log("[Warning]" + message);
    }
}