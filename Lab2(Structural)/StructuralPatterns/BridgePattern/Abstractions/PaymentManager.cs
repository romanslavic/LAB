using BridgePattern.Interfaces;

namespace BridgePattern.Abstractions;

public abstract class PaymentManager
{
    protected IPaymentProcessor PaymentProcessor;

    protected PaymentManager(IPaymentProcessor paymentProcessor)
    {
        PaymentProcessor = paymentProcessor;
    }
    
    public abstract void ProcessPayment(decimal amount);
}