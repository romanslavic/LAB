namespace DecoratorPattern;

public class DateTimeLogger : Decorator
{
    public DateTimeLogger(Logger logger) : base(logger)
    {
    }

    public override void Log(string message)
    {
        _logger.Log($"[{DateTime.Now:HH:mm:ss}]{message}");
    }
}