using AdapterPattern.Interfaces;
using AdapterPattern.Models;

namespace AdapterPattern;

public class PaymentManager : IPaymentManager
{
    public void ProcessPayment(EuroCurrency euro)
    {
        Console.WriteLine($"Payment successful with {euro.Amount * euro.ConversionRate} MDL");
    }
}