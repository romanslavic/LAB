using BridgePattern.Interfaces;

namespace BridgePattern.Implementors;

public class CryptoPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Binance Processed: {amount} USD");
    }
}