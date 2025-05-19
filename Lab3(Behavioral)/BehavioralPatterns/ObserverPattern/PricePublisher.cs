namespace ObserverPattern;

public abstract class PricePublisher
{
    protected List<ISubscriber> _subscribers = new List<ISubscriber>();
    
    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        foreach (var subscriber in _subscribers)
            subscriber.OnPriceChange();
    }
}