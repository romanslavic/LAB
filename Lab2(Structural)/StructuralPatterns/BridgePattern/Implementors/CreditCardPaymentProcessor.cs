using BridgePattern.Interfaces;

namespace BridgePattern.Implementors;

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Bank Processed {amount} USD");
    }
}