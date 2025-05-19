using BridgePattern.Interfaces;

namespace BridgePattern.Implementors;

public class PaypalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Paypal Processed {amount} USD");
    }
}