using BridgePattern.Abstractions;
using BridgePattern.Interfaces;

namespace BridgePattern.ConcreteManagers;

public class OneTimePaymentManager : PaymentManager
{
    public OneTimePaymentManager(IPaymentProcessor paymentProcessor) : base(paymentProcessor)
    {
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Processing One-Time Payment");
        PaymentProcessor.ProcessPayment(amount);
    }
}