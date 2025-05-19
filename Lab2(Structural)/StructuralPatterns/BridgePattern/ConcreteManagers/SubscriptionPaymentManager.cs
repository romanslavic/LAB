using BridgePattern.Abstractions;
using BridgePattern.Interfaces;

namespace BridgePattern.ConcreteManagers;

public class SubscriptionPaymentManager : PaymentManager
{
    public SubscriptionPaymentManager(IPaymentProcessor paymentProcessor) : base(paymentProcessor)
    {
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("");
        PaymentProcessor.ProcessPayment(amount);
    }
}