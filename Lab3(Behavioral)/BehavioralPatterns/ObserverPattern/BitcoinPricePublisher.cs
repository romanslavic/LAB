namespace ObserverPattern;

public class BitcoinPricePublisher : PricePublisher
{
    private double _price;

    public void SetLastPrice(double price)
    {
        _price = price;
        Notify();
    }

    public double GetLastPrice()
    {
        return _price;
    }
}