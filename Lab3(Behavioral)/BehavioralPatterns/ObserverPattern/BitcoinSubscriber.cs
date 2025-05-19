namespace ObserverPattern;

public class BitcoinSubscriber : ISubscriber
{
    private readonly BitcoinPricePublisher _pricePublisher;
    
    public BitcoinSubscriber(BitcoinPricePublisher pricePublisher)
    {
        _pricePublisher = pricePublisher;
    }
    
    public void OnPriceChange()
    {
        var price = _pricePublisher.GetLastPrice();
        Console.WriteLine($"[{GetHashCode()}]Bitcoin Price: " + price);
    }
}