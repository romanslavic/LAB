using DecoratorPattern;

var logger = new ErrorLevelLogger(
    new DateTimeLogger(
        new ConcreteLogger()));

logger.Log("This is an error");