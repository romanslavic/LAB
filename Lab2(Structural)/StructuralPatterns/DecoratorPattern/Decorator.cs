namespace DecoratorPattern;

public class Decorator : Logger
{
    protected Logger _logger;

    public Decorator(Logger logger)
    {
        _logger = logger;
    }

    public void SetLogger(Logger logger)
    {
        _logger = logger;
    }
    
    public override void Log(string message)
    {
        if (_logger != null)
        {
            _logger.Log(message);   
        }
        else
        {
            Console.WriteLine("Invalid logger");
        }
    }
}