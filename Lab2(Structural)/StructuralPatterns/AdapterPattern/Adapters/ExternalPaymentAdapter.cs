using AdapterPattern.Interfaces;
using AdapterPattern.Models;

namespace AdapterPattern.Adapters;

public class ExternalPaymentAdapter : IPaymentManager
{
    private readonly ExternalPayment _externalPayment = new ExternalPayment();
    
    public void ProcessPayment(EuroCurrency euro)
    {
        //Currency api call or something
        var usd = euro.Amount * 0.92;
        _externalPayment.ProcessUsdPayment(usd);
    }
}