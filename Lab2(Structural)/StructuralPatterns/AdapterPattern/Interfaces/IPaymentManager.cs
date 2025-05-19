using AdapterPattern.Models;

namespace AdapterPattern.Interfaces;

public interface IPaymentManager
{
    public void ProcessPayment(EuroCurrency euro);
}