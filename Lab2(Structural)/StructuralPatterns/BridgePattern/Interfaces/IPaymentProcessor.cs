namespace BridgePattern.Interfaces;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}